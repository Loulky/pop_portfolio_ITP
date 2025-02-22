import tkinter as tk
from tkinter import messagebox
import pystray
from PIL import Image, ImageTk
import os
import ctypes
from random import randrange
import json

# icons are form www.svgrepo.com

class BackgroundChanger(tk.Tk):
    def __init__(self):
        super().__init__()

        self.title("Background changer")
        self.geometry("300x150")
        self.protocol("WM_DELETE_WINDOW", self.minimize_to_tray)

        # Load and set the window icon
        icon_image = Image.open("app_icon.png")
        self.icon_photo = ImageTk.PhotoImage(icon_image)
        self.iconphoto(False, self.icon_photo)

        with open("data.json", "r") as file:
            self.vars = json.load(file)

        # put inputs and other stuff into app
        padding = {"padx": "5", "pady": "5"}
        # folder insert
        self.label = tk.Label(self, text="Folder path:")
        self.label.grid(row=0, column=0, **padding)
        self.folder_path_entry = tk.Entry(self, width=20)
        self.folder_path_entry.insert(0, self.vars["folder_path"])
        self.folder_path_entry.grid(row=0, column=1, **padding)
        # folder submit btn
        self.folder_path_btn = tk.Button(
            self, text="submit folder", command=self.folder_path_fce
        )
        self.folder_path_btn.grid(row=1, column=0, columnspan=2, **padding)

        # next img button
        self.next_img_btn = tk.Button(
            self, text="next background", command=self.wallpaper_change
        )
        self.next_img_btn.grid(row=2, column=0, padx=5)

        # Add cycle control button
        self.cycle_btn = tk.Button(
            self, text="Start Cycling", command=self.toggle_cycling
        )
        self.cycle_btn.grid(row=2, column=1, padx=5)

        # cycling variables
        self.is_cycling = False

    # cycling dependencies
    def toggle_cycling(self):
        if self.is_cycling:
            self.stop_cycling()
        else:
            self.start_cycling()

    def start_cycling(self):
        self.is_cycling = True
        self.cycle_btn.config(text="Stop Cycling")
        self.cycle_wallpaper()

    def stop_cycling(self):
        self.is_cycling = False
        self.cycle_btn.config(text="Start Cycling")

    def cycle_wallpaper(self):
        if self.is_cycling:
            self.wallpaper_change()
            self.after(3000, self.cycle_wallpaper)

    # folder path check
    def folder_path_fce(self):
        folder_path = self.folder_path_entry.get()
        path_exists = os.path.exists(folder_path)
        if path_exists:
            self.vars["folder_path"] = folder_path
            self.write_config()
        else:
            self.folder_path_entry.delete(0, tk.END)
            self.folder_path_entry.insert(0, self.vars["folder_path"])
            messagebox.showwarning("Warning", "This is not a folder")

    def minimize_to_tray(self):
        self.withdraw()
        image = Image.open("app_icon.png")
        menu = (
            pystray.MenuItem("Quit", self.quit_window),
            pystray.MenuItem("Show", self.show_window),
            pystray.MenuItem("Next one", self.wallpaper_change),
        )
        icon = pystray.Icon("name", image, "Background changer", menu)
        icon.on_click = self.show_window
        icon.run()

    def quit_window(self, icon):
        self.stop_cycling()
        icon.stop()
        self.destroy()

    def show_window(self, icon):
        icon.stop()
        self.after(0, self.deiconify)

    def write_config(self):
        with open("data.json", "w") as file:
            json.dump(self.vars, file, indent=4)

    def wallpaper_change(self):
        folder_path = self.vars["folder_path"]
        if not (os.path.exists(folder_path)):
            messagebox.showwarning("Warning", "Path in the config file does't exists")
            return

        img_files = [
            f for f in os.listdir(folder_path) if f.lower().endswith((".jpg", ".jpeg"))
        ]
        img_files_length = len(img_files)

        while True:
            radom_img = img_files[randrange(0, img_files_length)]
            if not radom_img in self.vars["last_images"]:
                break

        img_path = f"{folder_path}/{radom_img}"

        # check if the img exists
        if os.path.isfile(img_path):
            ctypes.windll.user32.SystemParametersInfoW(20, 0, img_path, 0)
        else:
            print("not a file")

        self.vars["last_images"].append(radom_img)
        self.vars["last_image"] = radom_img

        if len(self.vars["last_images"]) >= 10:
            del self.vars["last_images"][0]

        self.write_config()


if __name__ == "__main__":
    app = BackgroundChanger()

    # set initial wallpaper from config
    try:
        img_path = f"{app.vars['folder_path']}/{app.vars['last_image']}"
        if os.path.isfile(img_path):
            ctypes.windll.user32.SystemParametersInfoW(20, 0, img_path, 0)
    except Exception as e:
        print(f"Failed to set initial wallpaper: {e}")
    app.mainloop()

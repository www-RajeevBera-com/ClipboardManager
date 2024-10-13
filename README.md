# ClipboardManager Solution

## Overview
The **ClipboardManager** solution is a Windows Forms application that allows you to track, store, and manage your clipboard history. Users can view previously copied text, reuse it, or clear the history. This tool is perfect for those who want an easy way to manage their clipboard contents.

## Features
- **Clipboard History Tracking**: Automatically stores text copied to the clipboard.
- **History Reuse**: Double-click any item in the clipboard history to copy it back to the clipboard for reuse.
- **Clear History**: Provides an option to clear the clipboard history in one click.
- **Windows API Integration**: Uses Windows `user32.dll` to hook into clipboard events.

## How to Use

### 1. Build and Run
- After cloning the repository, open the **ClipboardManager** solution in Visual Studio.
- Build the solution.
- Run the project, which will open the Windows Forms interface.

### 2. Monitor Clipboard
- When the application starts, it will begin monitoring clipboard activity.
- Any text copied to the clipboard will appear in the clipboard history list.

### 3. Reuse Clipboard Content
- Double-click any item in the clipboard history to restore it to the clipboard.
- You can then paste it anywhere you'd like.

### 4. Clear Clipboard History
- Click the "Clear" button to remove all items from the clipboard history.

## Video Tutorial
Watch the full video tutorial on YouTube:
[Watch here](https://www.youtube.com/watch?v=wxIUYx8kJ_M)

## Licensing
This solution is licensed under the **MIT License**, which means you are free to:
- Use the code in your own projects.
- Modify, distribute, or build upon the project.
- Include it in your resume, portfolio, or any personal or commercial project.

## Contributing
Contributions are welcome! If you'd like to improve the project, feel free to submit a pull request. Let's enhance it together!

## Thank You
I hope this project helps you manage your clipboard history easily. If you enjoy it, consider sharing your improvements or letting me know how you use it!

Thank you for using **ClipboardManager**!

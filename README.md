# NET_MAUI_Bug_absoluteLayout
This is showing a bug in the AbsoluteLayout using an ImageButton. I am able to create a floating action button while preview/debug is running, but upon restarting the application the button layout breaks.

Steps to reproduce the issue:
1. Open this project in VS 2022
2. Remove the AbsoluteLayout with contents on the bottom of the page
3. Run the application in an emulator or your physical device
4. While in preview mode, manually re-write the AbsoluteLayout code with ImageButton - DO NOT COPY/PASTE, this does not reproduce the issue!
5. Watch the floating action button work as expected
6. Now restart the application in emulator or on your physical device
7. Watch the floating action button layout break entirely

Even after closing all your programs and removing the app from your emulator or physical device, the bug still persist.

If you <!-- Comment --> the AbsoluteLayout and manually write the exact same code above it, it works again.

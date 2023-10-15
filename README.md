# Text to Binary Converter

This C# console application is a simple utility that enables you to convert text to binary code. The program offers two conversion methods: direct input of a text string and conversion of text from a `.txt` file.

## How the Program Works

The program employs a `while` loop that continues until the user chooses to exit. Within the loop, you are presented with three options:

1. **Enter Text to Convert (Option 1):** If you select this option, you will be prompted to type in the text you wish to convert to binary. Once you have entered the text, the program will perform the conversion and display the result on the console.

2. **File Translation (Option 2):** Choosing this option will require you to specify the path to a `.txt` file containing the text you want to convert. The program will read the file, perform the conversion, and save the result in a new file with a timestamp in the filename. It will then show you the path to the converted file.

3. **Exit the Program (Option 3):** To exit the program, select this option.

## Code Explanation

Let's delve into the crucial elements of the code:

- The `InitialSettings` method configures the appearance of the console window and displays the initial menu.

- The `StringTranslation` method handles user input of text, converts it to binary, and displays the result.

- The `FileTranslation` method deals with text conversion from a specified file. It reads the text from the file, converts it to binary, and saves the result in a new file.

- The `Traslation` method (note the typo) converts text characters to binary representations. It leverages an `enum` called `BinaryAlphabet` to map alphabetic characters to their binary equivalents.

The `whileTrueFalse` variable controls the main loop of the program, ensuring that the menu and operations continue until the user opts to exit.

Please note that the code is basic and may benefit from improvements such as error handling and better variable naming. However, it serves as a fundamental example of text-to-binary conversion in C#.

## How to Use the Program

Follow these steps to use the program:

1. Clone or download the repository to your local machine.

2. Open the solution in Visual Studio or your preferred C# IDE.

3. Build and run the program.

4. Follow the on-screen instructions to convert text to binary or convert text from a file.

5. To exit the program, select option 3.

The code is open for your customization and extension. You can enhance it by adding error handling, improving the user interface, or making the binary representation more compact.

Enjoy converting text to binary with this utility!

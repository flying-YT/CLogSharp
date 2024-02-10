# CLogSharp
"CLogSharp" is a log output library for .net.
"CLogSharp" is compiled with .net6.

## Overview
- There are two types of classes in this library.
- ContinuousLogger writes logs to the specified file at any time.
- IntermittentLogger stores logs in objects and collectively creates log files.

## Usage(ContinuousLogger)
1. Add dll<br>
    Add the dll to your project
2. Add using<br>
    Add the following description
    ```
    using CLogSharp;
    ```
3. Change settings as needed.<br>
    Update the values ​​of A, B, and C.
    ```
    directory = Environment.CurrentDirectory;
    fileName = "log";
    extensionName = "txt";
    ```
4. Write log.<br>
    Call the method and write the log.
    ```
    WriteLogInfo("text");
    WriteLogError("text");
    ```

## Usage(IntermittentLogger)
1. Add dll<br>
    Add the dll to your project
2. Add using<br>
    Add the following description
    ```
    using CLogSharp;
    ```
3. Generate an instance.<br>
    Always call the initialization method first.
    ```
    IntermittentLogger.LogListInstance();
    ```
4. Write log.<br>
    Call the method and store the log..
    ```
    WriteLogInfo("text");
    WriteLogError("text");
    ```
5. Create a file and write the log.<br>
    Create a file and write the log.
    ```
    MakeLogFile("log fileName");
    ```

## Lisence
This project is licensed under the MIT License, see the LICENSE.txt file for details.
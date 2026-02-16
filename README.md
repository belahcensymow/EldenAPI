# EldenAPI

## 🚀 Quick Start

⚠️ This repository uses **Git Submodules** Clone it with:

```bash
git clone --recursive https://github.com/belahcensymow/EldenAPI.git
```
> [!NOTE]
> **Refer to the Samples directory for implementation examples. All functions are used and showcased there.**

## Features
* XML definitions are used to automatically generate .cs classes for strongly typed access and full IntelliSense coverage.
```C#
foreach (var posx regulation.BonfireWarpParam.PosX) 
	Console.WriteLine($"PosX: {posx}");
```

All files in regulation.bin are accessible from the regulation object
The file type is automatically determined and the correct .xml is applied then the corresponding .cs class for it it loaded.
The .cs class exposes all the properties and entries of the param with full IntelliSense again and the correct data type.
Internal data formats are converted their C# counterparts.
* The API provides handlers for *most files types: PARAM, PARAMDEF, MSGBND...
The rest will later be added.
These handlers provide one-line functions to find decompress and analyze the files.
They also provide helper functions that remove the boilerplate without being a technical burden so you can still any low-level thing you need, just in less lines.

## Future Plans
This API is just a part of a larger project to automate the process of data-borrowing from Elden Ring.
The process must be a one button push fully automatic process with deterministic logic and no hard-coded values.
And then this will be used as back-end for something else...

## Why
Just because Idk.
The creation of what I had in mind was painful, and with this library it became a bit less painful.

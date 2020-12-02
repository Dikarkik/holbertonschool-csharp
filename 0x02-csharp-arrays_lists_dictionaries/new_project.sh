#!/usr/bin/env bash
# creates a new C# project and build
dotnet new console -o $1
dotnet build $1

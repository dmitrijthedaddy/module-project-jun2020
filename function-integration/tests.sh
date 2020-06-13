#!/bin/bash

# этот сценарий - для тестов с компилятором mono в оболочке shell.
mcs Program.cs IntegrationMethods.cs FunctionData.cs -out:"function-integration.exe"
mono "function-integration.exe"
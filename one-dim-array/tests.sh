#!/bin/bash

mcs ArrayKit.cs Tests.cs -out:"one-dim-array.exe"
mono "one-dim-array.exe"
# [Getting Line Numbers](https://owml.outerwildsmods.com/guides/getting_started.html#getting-line-numbers)

When developing your mod you may want to get line numbers in your stack trace.

This mod replaces the **mono-2.0-bdwgc.dll** file within **MonoBleedingEdge/EmbedRuntime** of the game's files.
This will degrade performance slightly, but will allow all mods that use the **Portable** debug type to have line numbers.

If you've used the template to create your mod, simply build with the "Debug" release candidate to have DebugType set to portable.

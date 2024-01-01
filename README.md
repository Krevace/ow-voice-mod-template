# OW Voice Acting Mod Addon Template

This is a template for making your own addon to the [Outer Wilds Voice Acting Mod](https://github.com/Krevace/ow-voice-mod)! Why would you want to do this? You can swap the voices already in the mod with your own or even add custom voice lines if you're developing a mod that adds custom dialogue to the game. This template was generated from this [base](https://github.com/Krevace/ow-voice-mod-template-base). 

# Guide

If you're new to modding, check out [OWML's docs](https://owml.outerwildsmods.com/guides/getting_started.html#manifestjson) that explain the process.
<br/>

For this template specifically, there's only a few steps:
<br/>

1. Create a new repository by clicking `Use this Template` above.
2. Clone your new repository into a new folder in OWML's `Mods` folder, naming it `[AUTHOR].[MOD_UNIQUE_NAME]`.
3. Edit the `manifest.json` file, specifically the `AUTHOR`, `MOD_NAME`, and `MOD_UNIQUE_NAME` tags.
>* `AUTHOR` - your name
>* `MOD_NAME` - your readable mod name that others will see
>* `MOD_UNIQUE_NAME` - an ID for your mod that can be anything not already used by other mods
4. Edit the `README.md` file (easier to do in browser since you can preview) with an explanation of your mod to appear in the database.
5. Put in your voice lines! Just drag your audio files into the `assets` folder. If you don't know the filenaming convention, check out the [Discord](https://discord.gg/daHHqkKChm), where there's a complete video and text tutorial to guide you through the process. Also feel free to delete the file `THIS IS WHERE YOU PUT YOUR ASSETS`, it's just a reminder. 
6. If you want to change the custom credits for the mod, edit the `credits.xml` document in the `assets` folder. Line `171` is where the custom credits begin. Simply find the character(s) that you're patching and swap your name in. Or, if you're adding custom dialogue, then create a new line with `<spacer />` and `(REALNAME)#(CHARACTERNAME)`.
7. Test the mod to make sure it works!
8. When you're ready to publish, check [here](https://github.com/Raicuparta/ow-mod-template) under the "Releasing the Mod" section for help. One step will call for you to **zip** your release. Make sure to exclude the `README.md` and `LICENSE` files in this step. 

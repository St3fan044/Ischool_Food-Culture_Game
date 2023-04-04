﻿var plugin = {
    Download: async function()
    {
       const image = await fetch(imageSrc)
       const imageBlog = await image.blob()
       const imageURL = URL.createObjectURL(imageBlog)

       const link = document.createElement('a')
       link.href = imageURL
       link.download = 'image file name here'
       document.body.appendChild(link)
       link.click()
       document.body.removeChild(link)
    }
};

mergeInto(LibraryManager.library, plugin);

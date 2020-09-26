## Installation 


```
Install-Package KishAppBlazor.BlockUI
```


For client-side and server-side Blazor - add script section to index.html or _Host.cshtml (head section) 

```html
<script src="_content/KishAppBlazor.BlockUI/block-ui.js"></script>
<link href="_content/KishAppBlazor.BlockUI/block-ui.css" rel="stylesheet" />
```

Add the following using statement @using KishAppBlzaor.BlockUI to your desired Blazor component

## Usage


```html
@using KishAppBlzaor.BlockUI
@inject IJSRuntime JSRuntime

<div id="block-test">
  
</div>


@code
{

    protected override async Task OnInitializedAsync()
    {
      var blockUI = new BlockUI(JSRuntime);

      await blockUI.BlockAsync("#block-test", new BlockUIOptions { message = "شکیبا باشید" });
        await Task.Delay(10000);
      blockUI.Unblock("#block-test");
    }
} 
```

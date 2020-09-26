using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace KishAppBlazor.BlockUI
{
    public class BlockUI 
    {
        private static IJSRuntime JSRuntime { get; set;}
        public BlockUI(IJSRuntime Runtime)
        {
            JSRuntime = Runtime;
        }

        public async Task BlockAsync(string Target, BlockUIOptions? Options=null)
        {
            await Task.Delay(10);
            await JSRuntime.InvokeVoidAsync("KishApp.block", Target, Options);
        }
        public void Unblock(string Target)
        {
            JSRuntime.InvokeVoidAsync("KishApp.unblock", Target);
        }
        public void BlockPage(BlockUIOptions? Options = null)
        {
           JSRuntime.InvokeVoidAsync("KishApp.blockPage", Options);
        }
        public void UnblockPage()
        {
            JSRuntime.InvokeVoidAsync("KishApp.unblockPage");
        }
    }


    public class BlockUIOptions
    {
        public double opacity { get; set; }
        public string overlayColor { get; set; }
        public string type { get; set; }
        public string size { get; set; }
        public string state { get; set; }
        public bool centerX { get; set; }
        public bool centerY { get; set; }
        public string message { get; set; }
        public bool shadow { get; set; }
        public string width { get; set; }
    }


    }

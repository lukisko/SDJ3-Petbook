using System.Collections.Generic;
using System.Threading.Tasks;
using ClientApp.Model;
using Microsoft.AspNetCore.Components;

namespace  ClientApp.Pages
{ 
   public partial class Index :ComponentBase {
    
       

       protected override async Task OnInitializedAsync()
       {
         
       }
       private void NavigateToPetList()
       {
           NavMgr.NavigateTo($"/BrowsePets");
       }
   }
}
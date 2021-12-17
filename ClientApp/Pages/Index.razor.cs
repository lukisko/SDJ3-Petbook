using System.Collections.Generic;
using System.Threading.Tasks;
using ClientApp.Model;
using Microsoft.AspNetCore.Components;

namespace  ClientApp.Pages
{ 
   public partial class Index :ComponentBase {
    
       
       private void NavigateToPetList()
       {
           NavMgr.NavigateTo($"/BrowsePets");
       }
   }
}
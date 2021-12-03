using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using business_logic.Model.Mediator;
using System.Text.Json;
using business_logic.Data;
using business_logic.Model;

namespace business_logic
{
    public class Program
    {
        public async static Task Main(string[] args)
        {
            //Tier2 test = new Tier2(); //to test comunication uncomment this line and one of the bellow
            //await test.requestPets(); //delete also async
            //await test.createPet(new Model.Pet());
            //ITier2Mediator med = new Tier2();
            //Console.WriteLine("client connected!");
            //await med.requestPets();
            //IEmailHandler emailHandler = new EmailHandler();
            //emailHandler.sendEmail("lukas.pleva126@gmail.com","title","hello world");

            //Comunication<Pet> petCom = new Comunication<Pet>("type","method",new Pet(){user = new User(){email="ahoj"}});

            //string json = JsonSerializer.Serialize(petCom);
            //Comunication<Pet> petNew = JsonSerializer.Deserialize<Comunication<Pet>>(json);
            //Console.WriteLine(json);
            //Console.WriteLine(petNew.value.user.email);
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

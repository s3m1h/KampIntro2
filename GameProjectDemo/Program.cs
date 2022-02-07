// See https://aka.ms/new-console-template for more information
using GameProjectDemo;

GamerManager gamerManager = new GamerManager(new MernisUserValidationManager());
gamerManager.Save(new Gamer 
{ 
    Id = 1,
    FirstName="semih",
    BirthYear=1996,
    NationaltyId="123123123"
});

OrderGameManager orderGameManager = new OrderGameManager(new CampaignGameManager());
orderGameManager.Siparis(new Game
{
    Id = 2,
    GameName = "Call of Duty",
    GamePrice = 150,
}); 

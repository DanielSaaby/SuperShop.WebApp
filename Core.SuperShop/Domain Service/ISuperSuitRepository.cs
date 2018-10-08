using System.Collections.Generic;
using Entity;

namespace Core.SuperShop.Domain_Service
{
    public interface ISuperSuitRepository
    {
        SuperSuit NewSuperSuit(string name, string type, double price, string description);
        
        SuperSuit CreateSuperSuit(SuperSuit superSuit);

        List<SuperSuit> ReadAll();

        SuperSuit UpdateSuperSuit(int id);

        SuperSuit DeleteSuperSuit(int id);
    }
}
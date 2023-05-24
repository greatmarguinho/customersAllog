using Univali.Api.Entities;

namespace Univali.Api
{
    public class Data
    {
        public List<Customer> Customers{get; set;}
        private static Data ? _instance;

        private Data(){
            Customers = new List<Customer>
            {
                new Customer
                {
                    Id = 1,
                    Name = "Linus Torvalds",
                    Cpf = "07937045966"
                },

                new Customer
                {
                    Id = 2,
                    Name = "Marco",
                    Cpf = "07937045963"
                }
            };
        } 


        public static Data Instance{
            get
            {
                // return _instance ?? = new Data();
                if(_instance == null){
                    _instance = new Data();
                    return _instance;
                }
                    return _instance;
                }
            }
        }
}
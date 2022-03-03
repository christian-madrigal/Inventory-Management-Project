using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sneakers_mngmt
{
    interface CRUD
    {
        ICollection<Inventory> ReadInventories();
        int GetMaxID();
        void AddRecord(Inventory obj);
        void DeleteRecord(Inventory obj);
        ICollection<Inventory> GetInventories();
        Inventory FindInventory(int id);
        void UpdateRecord(int id, Inventory inventorychanges);

        ICollection<Customer> Readcustomers();
        int GetMaxNum();
        void AddRecord(Customer obj);
        void DeleteRecord(Customer obj);
        ICollection<Customer> GetCustomers();
        Customer FindCustomers(int id);
        void UpdateRecord(int id, Customer customerchanges);

    }

    class SneakerRepository : CRUD
    {
        SneakersEntities entities;



        public SneakerRepository()
        {
            entities = new SneakersEntities();
        }

        public void AddRecord(Inventory obj)
        {
            entities.Inventories.Add(obj);
            entities.SaveChanges();
        }

        public void AddRecord(Customer obj)
        {
            entities.Customers.Add(obj);
            entities.SaveChanges();
        }

        public void DeleteRecord(Inventory obj)
        {
            entities.Inventories.Remove(obj);
            entities.SaveChanges();
        }

        public void DeleteRecord(Customer obj)
        {
            entities.Customers.Remove(obj);
            entities.SaveChanges();
        }
        
        public Inventory FindInventory(int id)
        {
            var car = entities.Inventories.First(n => n.ItemID == id);
            if (car != null)
            {
                return car;
            }
            else
                return null;
        }

        public Customer FindCustomers(int id)
        {
            var car = entities.Customers.First(n => n.OrderID == id);
            if (car != null)
            {
                return car;
            }
            else
                return null;
        }

        public ICollection<Inventory> ReadInventories()
        {
            return entities.Inventories.ToList();
        }

        public ICollection<Customer> Readcustomers()
        {
            return entities.Customers.ToList();
        }


        public ICollection<Inventory> GetInventories()
        {
            return entities.Inventories.ToList();
        }

        public ICollection<Customer> GetCustomers()
        {
            return entities.Customers.ToList();
        }

        public int GetMaxID()
        {
            return entities.Inventories.Max(p => p.ItemID); 
        }

        public int GetMaxNum()
        {
            return entities.Customers.Max(p => p.OrderID);
        }

        public void UpdateRecord(int id, Inventory inventorychanges)
        {
            var invtoupdate = entities.Inventories.Find(id);
            invtoupdate.ItemID = inventorychanges.ItemID;
            invtoupdate.ShoePicture = inventorychanges.ShoePicture;
            invtoupdate.Name = inventorychanges.Name;
            invtoupdate.Color = inventorychanges.Color;
            invtoupdate.Size = inventorychanges.Size;
            invtoupdate.Qty= inventorychanges.Qty;
            invtoupdate.Price = inventorychanges.Price;
            invtoupdate.Sku = inventorychanges.Sku;
            entities.SaveChanges();
        }

        public void UpdateRecord(int id, Customer customerchanges)
        {
            var custoupdate = entities.Customers.Find(id);
            custoupdate.OrderID = customerchanges.OrderID;
            custoupdate.FirstName = customerchanges.FirstName;
            custoupdate.LastName = customerchanges.LastName;
            custoupdate.StreetAddress = customerchanges.StreetAddress;
            custoupdate.City = customerchanges.City;
            custoupdate.State = customerchanges.State;
            custoupdate.ZipCode = customerchanges.ZipCode;
            custoupdate.Sku = customerchanges.Sku;
            custoupdate.Size = customerchanges.Size;
        }


    }
}

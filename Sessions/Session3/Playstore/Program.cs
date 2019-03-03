using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playstore
{
    class Program
    {
        static void Main(string[] args)
        {
            Playstore ps1 = new Playstore();

            Game g1 = new Game(10, 20);
            Music m1 = new Music("Apple", 30);

            User u1 = new User("xyz", 1000);

            ps1.setUsersList(u1);

            ps1.setAppList(g1);
            ps1.setAppList(m1);

            Console.WriteLine(g1.getDownloadCounter());
            Console.WriteLine(u1.getBalance());
            ps1.purchaseContent(u1, g1);
            Console.WriteLine(g1.getDownloadCounter());
            Console.WriteLine(u1.getBalance());
            Console.ReadKey();

        }
    }

    class Playstore
    {

        private List<Application> appList;
        private List<User> usersList;


        public List<Application> getAppList()
        {
            return this.appList;
        }
        public void setAppList(Application app)
        {
            this.appList.Add(app);
        }

        public List<User> getUsersList()
        {
            return this.usersList;
        }
        public void setUsersList(User user)
        {
            this.usersList.Add(user);
        }


        public Playstore()
        {
            this.appList = new List<Application>();
            this.usersList = new List<User>();
        }

        public bool purchaseContent(User user, Application app)
        {
            if(user.getBalance() >= app.getPrice())
            {
                // Subtract the price from balance
                user.setBalance(user.getBalance() - app.getPrice());

                // Increment the number of downloads for the application
                app.incDownloadCounter();

                //add app to users installed app list
                user.addInstalledApps(app);
            }
            else
            {
                throw new Exception(" ");
            }
            return true;
        }


    }

    class Application {

        private int downloadCounter;
        private int price;


        public int getDownloadCounter()
        {
            return this.downloadCounter;

        }
        public void setDownloadCounter(int count)
        {
            this.downloadCounter = count;
        }
        public void incDownloadCounter()
        {
            this.downloadCounter++; 
        }
        
        public int getPrice()
        {
            return this.price;
        }
        public void setPrice(int count)
        {
            this.price = count;
        }

        public Application()
        {
            this.setDownloadCounter(0);
            this.setPrice(0);
        }

        public Application ( int price)
        {
            this.setDownloadCounter(0);
            this.setPrice(price); 
        }

    }


    class Music : Application {
        private string developerName;
        public string getDeveloperName()
        {
            return this.developerName;
        }
        public void setDeveloperName(string developerName)
        {
            this.developerName = developerName;
        }

        public Music():base()
        {
            this.setDeveloperName("");
        }

        public Music(string developerName):base( )
        {
            this.setDeveloperName(developerName);
        }

        public Music(string developerName,int price)
            : base(price)
        {
            this.setDeveloperName(developerName);
        }

    }

    class Game : Application {
        private int ageLimit;
        public int getAgeLimit()
        {
            return this.ageLimit;
        }   
        public void setAgeLimit(int ageLimit)
        {
            this.ageLimit = ageLimit; 

        }


        public Game() : base()
        {
            this.setAgeLimit(0);
        }

        public Game(int ageLimit ) : base()
        {
            this.setAgeLimit(ageLimit);
        }

        public Game(int ageLimit, int price)
            : base(price)
        {
            this.setAgeLimit(ageLimit);
        }
    }

    class User {
        private string name;
        private int balance;
        private List<Application> installedApps;
  

        public string getName()
        {
            return this.name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public int getBalance()
        {
            return this.balance;
        }
        public void setBalance(int balance)
        {
            this.balance = balance;
        }

        public List<Application> getInstalledApps()
        {
            return this.installedApps;
        }
        public void addInstalledApps(Application app)
        {
            this.installedApps.Add(app);
        }



        public User(string name)
        {
            this.setName(name);
            this.setBalance(0);
            this.installedApps = new List<Application>();
        }
        public User(string name, int balance)
        {
            this.setName(name);
            this.setBalance(balance);
            this.installedApps = new List<Application>();
        }


    }







}




























//class temp
//{
//    int a1, a2, a3, a0;

//    public temp()
//    {
//        a0 = 0;
//    }
//    public temp(int a1) : this()
//    {
//        this.a1 = a1;
//    }
//    public temp(int a1, int a2) : this(a1)
//    {
//        this.a2 = a2;
//    }
//    public temp(int a1, int a2, int a3) : this(a1, a2)
//    {
//        this.a0 = 0;
//        this.a1 = a1;
//        this.a2 = a2;
//        this.a3 = a3;
//    }


//    public void tempMain()
//    {
//        temp t0 = new temp();

//        temp t1 = new temp(10);
//    }
//}
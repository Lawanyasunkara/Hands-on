using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Sep14
{
    [Serializable()]
    public class Movie
    {
        public string mname
        {
            get;
            set;
        }
        public string mlanguage { get; set; }
        public string mgenre { get; set; }
        public int mstock { get; set; }
        public Movie(string name, string language, string genre, int stock)
        {
            mname = name;
            mlanguage = language;
            mgenre = genre;
            mstock = stock;

        }
        public Movie()
        {

        }
    }

    [Serializable()]
    public class Searching
    {
        public List<Movie> Search
        {
            get;
            set;
        }
        public static List<Movie> movies = new List<Movie>();
        public void initiate()
        {
            movies.Add(new Movie("Padayappa", "Tamil", "Action", 20));
            movies.Add(new Movie("Kanchana", "Tamil", "Thriller", 40));
            movies.Add(new Movie("Anandham", "Telugu", "Drama", 50));
            movies.Add(new Movie("Anjana", "Telugu", "Thriller", 60));
            movies.Add(new Movie("Atma", "Kannada", "Drama", 34));
        }
        public void search()
        {
            Console.WriteLine("Search by\n 1.Name\n 2.Language\n 3.Genre");
            int p = Convert.ToInt32(Console.ReadLine());
            switch (p)
            {
                case 1:
                    Console.WriteLine("Enter the movie name to search");
                    string q = Console.ReadLine();
                    var pt = movies.Where(pi => pi.mname == q).ToList();
                    if (pt != null)
                    {
                        Search = pt;
                    }
                    else
                    {
                        Console.WriteLine("Movie unavailable");
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter the movie language to search");
                    string qq = Console.ReadLine();
                    var hp = movies.Where(pi => pi.mlanguage == qq).ToList();
                    if (hp != null)
                    {
                        Search = hp;
                    }
                    else
                    {
                        Console.WriteLine("Language unavailable");
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter the movie genre to search");
                    string rrr = Console.ReadLine();
                    var hpp = movies.Where(pi => pi.mgenre == rrr).ToList();
                    if (hpp != null)
                    {
                        Search = hpp;
                    }
                    else
                    {
                        Console.WriteLine("Language unavailable");
                    }
                    break;

            }
        }
        public void AddMovies()
        {
            Movie m = new Movie();
            Console.WriteLine("Enter movie name");
            m.mname = Console.ReadLine();
            Console.WriteLine("Enter movie language");
            m.mlanguage = Console.ReadLine();
            Console.WriteLine("Enter movie genre");
            m.mgenre = Console.ReadLine();
            Tuple<string, string, string> mi = Tuple.Create<string, string, string>(m.mname, m.mlanguage, m.mgenre);
            Predicate<Tuple<string, string, string>> k = (i) =>
            {
                int flag = 0;
                foreach (var item in movies)
                {
                    if (item.mname == i.Item1 && item.mlanguage == i.Item2 && item.mgenre == i.Item3)
                    {
                        flag = 1;
                        break;
                    }

                }
                if (flag == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
            if (k(mi))
            {
                Console.WriteLine("Already Exists");
            }
            else
            {
                movies.Add(m);

            }
        }
        public void DeleteMovies()
        {

            Movie md = new Movie();
            Console.WriteLine("Enter movie name");
            md.mname = Console.ReadLine();
            Console.WriteLine("Enter movie language");
            md.mlanguage = Console.ReadLine();
            Console.WriteLine("Enter movie genre");
            md.mgenre = Console.ReadLine();
            foreach (var item in movies)
            {
                if (item.mname == md.mname && item.mlanguage == md.mlanguage && item.mgenre == md.mgenre)
                {

                    movies.Remove(item);
                }

            }

        }

        public void DisplayMovies()
        {
            foreach (var item in movies)
            {
                Console.WriteLine($"{item.mname} {item.mlanguage} {item.mgenre}");
            }
        }
    }
    [Serializable()]
    public class CustomerUser : Searching
    {

        public long Id { get; set; }

        public string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string login
        {
            get;
            set;
        }
        public DateTime date
        {
            get { return DateTime.Now; }
        }
        public bool validate()
        {
            if (Id == 7893957714 && Password == "123456789")
            {
                login = "true";
                return true;
            }
            else
            {
                login = "false";
                return false;
            }
        }


        public List<Movie> alreadyseen
        {
            get;
            set;
        }





    }
    [Serializable()]
    public class Watch : Searching
    {
        public List<Tuple<Movie, DateTime>> watchlist = new List<Tuple<Movie, DateTime>>();
        public List<Tuple<Movie, int>> release = new List<Tuple<Movie, int>>();
        public List<Tuple<string, int, double>> total = new List<Tuple<string, int, double>>();
        public void Addtowatchlist()
        {
            string s = Console.ReadLine();
            var oi = movies.Where(p => p.mname == s).ToList();
            if (oi != null)
            {
                foreach (Movie item in oi)
                {

                    Console.WriteLine(item.mname);

                    movies.Remove(item);
                    item.mstock = item.mstock - 1;
                    Console.WriteLine("Enter year");
                    int yr1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter month");
                    int mon1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter date");
                    int dt1 = Convert.ToInt32(Console.ReadLine());
                    DateTime t1 = new DateTime(yr1, mon1, dt1);

                    Tuple<Movie, DateTime> ki = Tuple.Create<Movie, DateTime>(item, t1);
                    movies.Add(item);
                    watchlist.Add(ki);


                }

            }
            else
            {
                Console.WriteLine("Cannot be added");
            }

        }
        public void releaselist()
        {

            string cp = Console.ReadLine();
            Tuple<Movie, DateTime> k = null;
            foreach (var item in watchlist)
            {
                if (cp == item.Item1.mname)
                {
                    k = item;

                    movies.Remove(item.Item1);
                    item.Item1.mstock = item.Item1.mstock + 1;

                    Console.WriteLine("Enter year");
                    int yr = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter month");
                    int mon = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter date");
                    int dt = Convert.ToInt32(Console.ReadLine());
                    DateTime t = new DateTime(yr, mon, dt);
                    TimeSpan ts = t - item.Item2;
                    Tuple<Movie, int> poi = Tuple.Create<Movie, int>(item.Item1, ts.Days);
                    release.Add(poi);
                    movies.Add(item.Item1);


                }


            }
            watchlist.Remove(k);
        }
        public void totalcostassociated(string p)
        {
            int flag = 0;
            foreach (var item in release)
            {
                if (p == item.Item1.mname)
                {
                    flag = 1;
                    Console.WriteLine(item.Item1.mname);
                    Console.WriteLine("Enter the cost for one day");
                    double Cost = Convert.ToInt32(Console.ReadLine());
                    double k = 0.18 * Cost;
                    double ky = item.Item2 * 0.01 * Cost;
                    double ut = k + ky + Cost;
                    Console.WriteLine($"GST is {k}");
                    Console.WriteLine($"Bluray cost is {ky}");
                    Console.WriteLine("Total cost is" + " " + ut);
                    Tuple<string, int, double> k2 = Tuple.Create(item.Item1.mname, item.Item2, ut);

                    total.Add(k2);
                }
            }
            foreach (var item in watchlist)
            {
                if (p == item.Item1.mname)
                {
                    Console.WriteLine(item.Item1.mname);
                    Console.WriteLine("Enter the cost for single day");
                    double Cost = Convert.ToInt32(Console.ReadLine());
                    TimeSpan tu = DateTime.Now - item.Item2;
                    double l = 0.18 * Cost;
                    double ky = (tu.Days) * 0.01 * Cost;
                    double ut = l + ky + Cost;
                    Console.WriteLine($"GST is {l}");
                    Console.WriteLine($"Bluray cost is {ky}");
                    Console.WriteLine("Total cost is" + " " + ut);
                    Tuple<string, int, double> k2 = Tuple.Create(item.Item1.mname, tu.Days, ut);

                    total.Add(k2);
                }
                else if (flag != 1)
                {
                    foreach (var item1 in movies)
                    {
                        if (p == item1.mname)
                        {

                            Console.WriteLine(item1.mname);
                            Console.WriteLine("Enter the cost for Single day");
                            double Cost = Convert.ToInt32(Console.ReadLine());

                            double k = 0.18 * Cost;
                            double ky = 0 * 0.01 * Cost;
                            double ut = k + ky + Cost;
                            Console.WriteLine($"GST is {k}");
                            Console.WriteLine($"Bluray cost is {ky}");
                            Console.WriteLine("Total cost is" + " " + ut);
                            Tuple<string, int, double> k2 = Tuple.Create(item.Item1.mname, 0, ut);

                            total.Add(k2);
                        }
                    }

                }
            }
        }


    }
}
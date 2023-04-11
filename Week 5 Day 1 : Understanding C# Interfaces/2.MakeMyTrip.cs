using System;
using System.Collections.Generic;
class MakeMyTrip:HotelTariff //Fill your code here
{
    Dictionary<string,Dictionary<string, double>> HotelList = new Dictionary<string,Dictionary<string, double>>
    {
        {
        "Tokyo",
        new Dictionary<string,double>
        {
            {"Tokyo Residency",10000},
            {"Heritage Tokyo",15000},
            {"Germanus",20000}
        }
        },

        {
        "Singapore",
        new Dictionary<string,double>
        {
            {"Hotel CAG Pride",15000},
            {"Heritage Inn",25000}
        }
        }
    };
	public void CityList()
    {
        foreach(string city in HotelList.Keys)
        {
        
        Console.WriteLine(city);
        }
        //Fill your code here
    }
    
    public void ShowTariff(string city)
    {
        if(HotelList.ContainsKey(city))
        {
            Console.WriteLine("Hotel List with Tariff:");
            foreach(KeyValuePair<string,double> hotel in HotelList[city])
            {
                Console.WriteLine(hotel.Key+" - Rs."+hotel.Value);
            }
        }
        else
        {
            Console.WriteLine("Selected City not found...");
        }
        //Fill your code here
    }
}

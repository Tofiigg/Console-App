namespace ConsoleApp1.Models
{
    public class Room
    {
        public int RoomNumber;
        public string type;
        public int RoomPrice;

        public Room(int number, string Type, int price)
        {
            this.RoomNumber = number;
            this.type = Type;
            this.RoomPrice = price;
        }
    }

}
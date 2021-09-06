using ConsoleApp1.Models;
using ConsoleApp1.Tip;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Services
{
    class Room_Service : ICrudService<Room>
    {
        List<Room> rooms = new List<Room>() {
            new Room(100,"Single", 200),
            new Room(101,"Single", 200),
            new Room(102,"Single", 200)


        };
        public bool Create(Room model)
        {
            rooms.Add(model);
            return true;
        }

        public Room Delete(int id)
        {
            Room room = rooms.Find(r=>r.RoomNumber==id);
            rooms.Remove(room);
            return room;
        }

        public List<Room> GetAll()
        {
            return rooms;
        }

        public Room GetById(int id)
        {
            Room room = rooms.Find(r => r.RoomNumber == id);
            return room;
        }

        public bool Update(int id, Room model)
        {
            Room room = rooms.Find(r => r.RoomNumber == id);
            rooms.Remove(room);
            rooms.Add(model);
            return true;
        }

        bool ICrudService<Room>.Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}

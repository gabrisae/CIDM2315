namespace FinalProject;

class Program
{
      public class Room {

        public static List<Room> filteredRoomList = new List<Room>();
        public static List<Room> roomList = new List<Room>();
        public static List<Room> reservedRoomList = new List<Room>();
        public int roomNum;
        public bool isRoomReserved;
        private string? roomGuestName;
        private string? roomGuestEmail;
        public int roomCapacity;
        public string? RoomGuestName
        {
            get; set;
        }

        public string? RoomGuestEmail
        {
            get; set;
        }

        public Room(int initRoomNum, int initRoomCapacity)
        {
            roomNum = initRoomNum;
            roomCapacity = initRoomCapacity;
            roomList.Add(this);
            isRoomReserved = false;
            roomGuestEmail = null;
            roomGuestName = null;
        }
  
  public static void Main(string[] args)
    {  
       
        Room room101 = new Room(101, 2);
        Room room102 = new Room(102, 2);
        Room room103 = new Room(103, 2);
        Room room104 = new Room(104, 2);
        Room room105 = new Room(105, 2);
        Room room106 = new Room(106, 2);
        Room room107 = new Room(107, 3);
        Room room108 = new Room(108, 3);
        Room room109 = new Room(109, 3);
        Room room110 = new Room(110, 4);

        Dictionary<string,string> userDict = new Dictionary<string, string>();
        userDict.Add("alice","alice123");

        Console.Write("-----CIDM 2315 Final Project: Gabriela Saenz-----\n-----Welcome to Buff Hotel-----\n");
        ReadLogin();

        void ReadLogin()
        {
            bool loginComplete = false;
            do {
            Console.WriteLine("--> Please input username:");
            string? username = Convert.ToString(Console.ReadLine());
            Console.WriteLine("--> Please input password");
            string? password = Convert.ToString(Console.ReadLine());
            if (username!=null&&password!=null){
            if (userDict.ContainsKey(username)&&userDict.ContainsValue(password))
            {
                Console.WriteLine("\n--> Login Successful");
                loginComplete = true;
                MainMenu();
            }
            else {
                Console.WriteLine("\n--> Wrong Username/Password");
                loginComplete = false;
            }
            }
            }
            while (loginComplete==false);
        }
        static void MainMenu()
        {
            bool menuExit = false;
            Console.WriteLine();
            Console.WriteLine("**Buff Hotel Main Menu**");
            Console.WriteLine("***Hello User: alice***");
            Console.WriteLine("*****************************");
            do {
            Console.WriteLine("--> Please select an option:");
            Console.Write("\n1. Show Available Rooms\n2. Check-In\n3. Show Reserved Rooms\n4. Check-Out\n5. Log Out\n");
            Console.WriteLine("*****************************");
            var menuSelect = Convert.ToString(Console.ReadLine());
            switch (menuSelect)
            {
                default:
                Console.WriteLine("---> Invalid entry.");
                continue;
                case "1":
                ShowAvailableRooms(0);
                continue;
                case "2":
                CheckIn();
                continue;
                case "3":
                ShowReservedRooms();            
                continue;    
                case "4":
                CheckOut();
                continue;
                case "5":
                Console.Write("Bye alice.");
                Console.Write("Logged out of system.");
                menuExit = true;
                break;
            }
        } while (menuExit == false);
        bool ShowAvailableRooms(int desiredCapacity) {
            bool areRoomsAvailable = false;
            Room.filteredRoomList.Clear();
            var filteredRooms = Room.roomList.Where(Room => Room.roomCapacity >= desiredCapacity);
            foreach(var Room in filteredRooms)
             {
                    Console.WriteLine($"++ Room Number: {Room.roomNum}, Room Capacity: {Room.roomCapacity}");
                    Room.filteredRoomList.Add(Room);
            }
            if (Room.filteredRoomList.Count > 0 ){
            Console.WriteLine($"--> Total available rooms: {Room.filteredRoomList.Count}");
                areRoomsAvailable=true;
                filteredRooms = null;
                return areRoomsAvailable;
            }
            else
            {
                Console.WriteLine("-----Number of Available Rooms : 0 -----");
                Console.WriteLine("--> No Suitable room at this time.");
                areRoomsAvailable=false;
                filteredRooms = null;
                return areRoomsAvailable;
            }
        }

         void CheckIn() {
            Console.WriteLine("--> Input desired room capacity:");
            int desiredCapacity = Convert.ToInt16(Console.ReadLine());
            bool areRoomsAvailable = ShowAvailableRooms(desiredCapacity);
            if (areRoomsAvailable == true)
            {
            Console.WriteLine("--> Input room number:");
            int desiredRoom = Convert.ToInt16(Console.ReadLine());
            bool roomOnReservedList = Room.reservedRoomList.Any(Room => Room.roomNum == desiredRoom);
            if (roomOnReservedList==false) {
            Console.WriteLine("---> Input Customer Name:");
            string? guestName = Console.ReadLine();
            Console.WriteLine("---> Input Customer Email:");
            string? guestEmail = Console.ReadLine();
                foreach (var room in Room.filteredRoomList.Where(Room => Room.roomNum == desiredRoom))
                {
                    room.isRoomReserved = true;
                    room.RoomGuestEmail = guestEmail;
                    room.RoomGuestName = guestName;
                    Room.reservedRoomList.Add(room);
                    Room.roomList.Remove(room);
                    Console.WriteLine($"Check-In successful! {room.RoomGuestName} is assigned to {room.roomNum}.");
                    }
                }
        else if (roomOnReservedList==true) {
         Console.WriteLine($"---> Room is already reserved to another guest");
              }
              }
         }

    static void ShowReservedRooms() {
            Console.WriteLine("---Reserved Room List---");
            foreach (var room in Room.reservedRoomList) 
            {
      Console.WriteLine($"++ Room: {room.roomNum}; Guest: {room.RoomGuestName}");
            }
        }

        static void CheckOut() {
            Console.WriteLine("---> Please input room number:");
            int desiredRoom = Convert.ToInt16(Console.ReadLine());
            bool roomOnReservedList = Room.reservedRoomList.Any(Room => Room.roomNum == desiredRoom);
            if (roomOnReservedList==true)
            {
                var toBeRemovedList = Room.reservedRoomList.ToList();
                 foreach (var room in toBeRemovedList.Where(Room => Room.roomNum == desiredRoom)){
                    Console.WriteLine($"---> Room: {room.roomNum}; Guest {room.RoomGuestName}");
                    Console.WriteLine("---> Please confirm the customer name and input y to continue Check-Out OR input any other key to cancel.");
                    string? response = Convert.ToString(Console.ReadLine());
                    if (response!=null)
                    {
                        if (response=="y")
                        {
                            roomOnReservedList=false;
                            room.isRoomReserved=false;
                            Room.roomList.Add(room);
                            var sortedRoomList = Room.roomList.OrderBy(Room => Room.roomNum).ToList(); // Ephemeral sortedRoomList becomes an ordered version of roomList
                            Room.reservedRoomList.Remove(room);
                            ShowReservedRooms();
                            Room.roomList.Clear(); // Clearing existing roomlist
                            Room.roomList = sortedRoomList; // roomList becomes ordered list from sortedRoomList
                            Console.WriteLine($"--> Check Successful! Guest {room.RoomGuestName} has been checked out from {room.roomNum}.");
                        }
                        else 
                        {
                            Console.WriteLine("--> Cancel Check-Out.");
                        }
                    }
                  }
                }
            else 
            {
                Console.WriteLine("--> Could not find customer record for this room.");
            }
        }
        }
    }
      }
}

        
    //ChatGPT, 2023, May 2. "Please help me with Error CS1002".
    //ChatGPT, 2023, May 2. "Please help me with Error CS0116".
    //ChatGPT, 2023, May 9. "Please help me with else statements".
    //Searched and asked pretty much every question along the way.
    // Also recieved help from online tutoring. 


    
  
    

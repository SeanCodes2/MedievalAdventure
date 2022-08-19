using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureLibrary
{
    public class Location
    {
        //Field | _camelCase | Access Modifier Private
        private string _name;
        private int _id;
        private string _decription;
        private Location _north;
        private Location _east;
        private Location _south;
        private Location _west;
        private bool _hasStore;
        private int _dangerLvl;
        private bool _hasLoot;

        //Props | PascalCase of _fieldName | Public Access | Encapsulate the fields from users
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Description
        {
            get { return _decription; }
            set { _decription = value; }
        }
        public Location North
        {
            get { return _north; }
            set { _north = value; }
        }
        public Location East
        {
            get { return _east; }
            set { _east = value; }
        }
        public Location South
        {
            get { return _south; }
            set { _south = value; }
        }
        public Location West
        {
            get { return _west; }
            set { _west = value; }
        }
        public bool HasStore
        {
            get { return _hasStore; }
            set { _hasStore = value; }
        }
        public int DangerLvl
        {
            get { return _dangerLvl; }
            set { _dangerLvl = value; }
        }
        public bool HasLoot
        {
            get { return _hasLoot; }
            set { _hasLoot = value; }
        }

        //Constructors | camelCase of props | Public Access | Recreate default CTOR

        public Location(string name, int id, string description, bool hasStore, int dangerLvl, bool hasLoot)
        {
            Name = name;
            Id = id;
            Description = description;
            HasStore = hasStore;
            DangerLvl = dangerLvl;
            HasLoot = hasLoot;
        }

        public Location() { }

        //Methods | Actions related to or using props of our object

        public override string ToString()
        {
            //return base.ToString();
            return $"{Name}";
        }



    }
}

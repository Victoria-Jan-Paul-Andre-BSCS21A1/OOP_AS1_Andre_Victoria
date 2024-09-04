namespace Pet_Inventory
{
    class Lizard : Pet, AnimalMakeSound
    {
        private string _venomous = string.Empty;
        public void SetVenom(string venomous) => this._venomous = venomous;
        public string GetVenom() => this._venomous;

        public string makeSound => "tsss";
        public override string ToString()
        {
            return $"{kind} - {animalName} ({gender}), Owner: {ownerName}, Venomous: {GetVenom()}, Sound: {makeSound}";
        }
    }

            

            }
        

 

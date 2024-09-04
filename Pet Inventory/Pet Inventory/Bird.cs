namespace Pet_Inventory
{
    class Bird : Pet, AnimalMakeSound
    {
        private string _sharpClaws = string.Empty;
        public void SetClaws(string claws) => this._sharpClaws = claws;
        public string GetClaws() => this._sharpClaws;

        public string makeSound => "tweet";
        public override string ToString()
        {
            return $"{kind} - {animalName} ({gender}), Owner: {ownerName}, Sharp Claws: {GetClaws()}, Sound: {makeSound}";
        }
    }

            

            }
        

 

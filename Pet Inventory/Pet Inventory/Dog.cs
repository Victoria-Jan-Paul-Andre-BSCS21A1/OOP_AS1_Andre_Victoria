namespace Pet_Inventory
{
    class Dog : Pet, AnimalMakeSound
    
    {

        private string _breed = string.Empty;
        public void SetBreed(string breed) => this._breed = breed;
        public string GetBreed() => this._breed;

        public string makeSound => "woof";
        public override string ToString()
        {
            return $"{kind} - {animalName} ({gender}), Owner: {ownerName}, Breed: {GetBreed()}, Sound: {makeSound}";
        }

    }
}
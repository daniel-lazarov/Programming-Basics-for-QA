int aquariumLenght = int.Parse(Console.ReadLine());
int aquariumWidth = int.Parse(Console.ReadLine());
int aquariumHeight = int.Parse(Console.ReadLine());
double percantage = double.Parse(Console.ReadLine());

int aquariumVolumeCm = aquariumLenght * aquariumWidth * aquariumHeight;

double aquariumVolumeL = aquariumVolumeCm * 0.001;

double requiredLiters = aquariumVolumeL - (aquariumVolumeL * percantage / 100);


//Console.WriteLine(aquariumVolumeL);
Console.WriteLine($"{requiredLiters:F2}");
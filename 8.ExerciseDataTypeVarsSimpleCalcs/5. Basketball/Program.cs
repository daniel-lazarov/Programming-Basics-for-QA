int trainingFee = int.Parse(Console.ReadLine());

double basketSneakers = trainingFee - (trainingFee * 0.4);
double basketTeam = basketSneakers - (basketSneakers * 0.2);
double basketBall = basketTeam * 0.25;
double basketAccessories = basketBall * 0.2;

double grandTotal = trainingFee + basketSneakers + basketTeam + basketBall + basketAccessories;

Console.WriteLine(grandTotal);
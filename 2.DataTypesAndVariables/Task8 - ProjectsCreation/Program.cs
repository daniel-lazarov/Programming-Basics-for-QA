string archName = Console.ReadLine();
int projectsCount = int.Parse(Console.ReadLine());
int hoursToCreate = projectsCount * 3;
Console.WriteLine($"The architect {archName} will need {hoursToCreate} hours to complete {projectsCount} project/s.");
class FitnessHelper {

    private static double[,] distanceMatrix;
    private static Parameters parameters = new Parameters();

    public static double[,] DistanceMatrix
    {
        set => distanceMatrix = value;
    }


    public static void setFitnessOfIndividual(Individual individual) {

        double fitness = 0;
        int totalDepth = individual.Cities.Length;

        bool hasDuplicates = false;

        if(parameters.CROSSOVER_METHOD == Parameters.CrossoverMethod.ONE_POINT_NORMAL) {

            HashSet<int> seen = new HashSet<int>();

            foreach (int city in individual.Cities)
            {
                if (!seen.Add(city))
                {
                    hasDuplicates = true;
                    break; // Exit the loop early if a duplicate is found
                }
            }
        }

        if(hasDuplicates) {
            fitness = double.MaxValue;
        }
        else {

            for(int i = 1; i < totalDepth; i++) {

                int firstCity = individual.Cities[i - 1];
                int secondCity = individual.Cities[i];

                double distance = distanceMatrix[firstCity, secondCity];

                fitness += distance;
            }

            fitness += distanceMatrix[individual.Cities[0], individual.Cities[totalDepth - 1]];
        }

        individual.Fitness = fitness;
    }
}
using System;
using System.Collections.Generic;

namespace RecipeApplication
{
    class Recipe
    {
        public int NumIngredients { get; set; }
        public int NumSteps { get; set; }
        public string[] IngredientNames { get; set; }
        public double[] IngredientQuantities { get; set; }
        public string[] IngredientUnits { get; set; }
        public string[] Steps { get; set; }

        public void DisplayRecipe()
        {
            Console.WriteLine("Ingredients:");
            for (int i = 0; i < NumIngredients; i++)
            {
                Console.WriteLine($"{IngredientQuantities[i]} {IngredientUnits[i]} of {IngredientNames[i]}");
            }

            Console.WriteLine("\nSteps:");
            for (int i = 0; i < NumSteps; i++)
            {
                Console.WriteLine($"{i + 1}. {Steps[i]}");
            }
        }

        public void ScaleRecipe(double factor)
        {
            for (int i = 0; i < NumIngredients; i++)
            {
                IngredientQuantities[i] *= factor;
            }
        }

        public void ResetQuantities()
        {
            // Implement code to reset the ingredient quantities to their original values
        }

        public void ClearRecipe()
        {
            NumIngredients = 0;
            NumSteps = 0;
            IngredientNames = null;
            IngredientQuantities = null;
            IngredientUnits = null;
            Steps = null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Recipe recipe = new Recipe();
            List<string> ingredientNames = new List<string>();
            List<double> ingredientQuantities = new List<double>();
            List<string> ingredientUnits = new List<string>();
            List<string> steps = new List<string>();

            Console.Write("Enter the number of ingredients: ");
            recipe.NumIngredients = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < recipe.NumIngredients; i++)
            {
                Console.Write($"Enter the name of ingredient {i + 1}: ");
                ingredientNames.Add(Console.ReadLine());

                Console.Write($"Enter the quantity of {ingredientNames[i]}: ");
                ingredientQuantities.Add(Convert.ToDouble(Console.ReadLine()));

                Console.Write($"Enter the unit of measurement for {ingredientNames[i]}: ");
                ingredientUnits.Add(Console.ReadLine());
            }

            recipe.IngredientNames = ingredientNames.ToArray();
            recipe.IngredientQuantities = ingredientQuantities.ToArray();
            recipe.IngredientUnits = ingredientUnits.ToArray();

            Console.Write("\nEnter the number of steps: ");
            recipe.NumSteps = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < recipe.NumSteps; i++)
            {
                Console.Write($"Enter step {i + 1}: ");
                steps.Add(Console.ReadLine());
            }

            recipe.Steps = steps.ToArray();

            recipe.DisplayRecipe();

            Console.Write("\nEnter the scaling factor (0.5, 2, or 3): ");
            double factor = Convert.ToDouble(Console.ReadLine());
            recipe.ScaleRecipe(factor);

            recipe.DisplayRecipe();

            recipe.ResetQuantities();

            recipe.DisplayRecipe();

            recipe.ClearRecipe();
        }
    }
}


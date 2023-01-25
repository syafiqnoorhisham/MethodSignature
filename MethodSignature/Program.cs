using System;
using System.Threading.Tasks;

namespace MethodSignature
{
    class SomeClass
    {
        static async Task Main(string[] args)
        {
            var someClass = new SomeClass();
            var (averageSalary, numberOfEmployee) =
            await someClass.SomeCalculation(0L, 10, 0L == 10L);
        }

        public async Task<(long, int)> SomeCalculation(long initialValue, int numberOfIterations, bool someCondition)
        {
            long totalSalary = initialValue;
            int employeeCount = 0;

            // Perform some asynchronous calculation
            await Task.Delay(1000);

            for (int i = 0; i < numberOfIterations; i++)
            {
                if (someCondition)
                {
                    totalSalary += i;
                    employeeCount++;
                }
            }

            return (totalSalary / employeeCount, employeeCount);
        }
    }
}


using Newtonsoft.Json;
using System.Reflection;

namespace UnitTestsWithJsonData.Common
{
    public class BaseClassData<T> : IEnumerable<object[]>
    {
        public string FilePath { get; }

        public BaseClassData(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
            {
                throw new ArgumentException("File path cannot be null or empty.", nameof(filePath));
            }

            FilePath = filePath;
        }

        public IEnumerable<object[]> GetData()
        {
            string assemblyLocation = Assembly.GetExecutingAssembly().Location;

            string assemblyDirectory = Path.GetDirectoryName(assemblyLocation);

            string solutionDirectory = Path.GetFullPath(Path.Combine(assemblyDirectory, @"..\..\.."));

            var pathToReadFrom = Path.Combine(solutionDirectory, FilePath);

            var data = File.ReadAllText(pathToReadFrom);

            var testData = JsonConvert.DeserializeObject<List<T>>(data);

            foreach (var item in testData)
            {
                yield return new object[] { item };
            }
        }

        public IEnumerator<object[]> GetEnumerator()
        {
            foreach (var item in GetData())
            {
                yield return item;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
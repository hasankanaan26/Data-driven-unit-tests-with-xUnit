using UnitTestsWithJsonData.Common;

namespace UnitTestsWithJsonData.Average
{
    public class AverageOperationClassData : BaseClassData<AverageOperationTestSet>
    {
        public AverageOperationClassData() : base(@"Average\AverageOperationData.Json")
        {
        }
    }
}
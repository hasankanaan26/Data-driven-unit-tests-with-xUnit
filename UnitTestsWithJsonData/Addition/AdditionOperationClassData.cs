using UnitTestsWithJsonData.Common;

namespace UnitTestsWithJsonData.Addition
{
    public class AdditionOperationClassData : BaseClassData<AdditionOperationTestSet>
    {
        public AdditionOperationClassData() : base(@"Addition\AdditionData.Json")
        {
        }
    }
}
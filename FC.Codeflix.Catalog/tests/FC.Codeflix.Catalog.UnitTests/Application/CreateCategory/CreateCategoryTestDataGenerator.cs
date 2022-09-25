namespace FC.Codeflix.Catalog.UnitTests.Application.CreateCategory;

public class CreateCategoryTestDataGenerator
{
    public static IEnumerable<object[]> GetInvalidInputs()
    {
        var fixture = new CreateCategoryTestFixture();
        var invalidInputsList = new List<object[]>();

        invalidInputsList.Add(new object[]
        {
            fixture.GetInvalidInputShortName(),
            "Name should be at least 3 characters long"
        });

        invalidInputsList.Add(new object[]
        {
            fixture.GetInvalidInputTooLongName(),
            "Name should be less or equal 255 characters long"
        });

        invalidInputsList.Add(new object[]
        {
            fixture.GetInvalidInputDescriptionNull(),
            "Description should not be null"
        });

        invalidInputsList.Add(new object[]
        {
            fixture.GetInvalidInputTooLongDescription(),
            "Description should be less or equal 10000 characters long"
        });

        return invalidInputsList;
    }
}

using Expense.Service;
using Expense.Service.Expense;
using Expense.Service.Projects;
using Xunit;

namespace Expense.Service.Test
{
    public class ExpenseServiceTest
    {
        [Fact]
        public void Should_return_internal_expense_type_if_project_is_internal()
        {
            // given
            var project = new Project(ProjectType.INTERNAL, "Internal Project");
            // when
            var result = ExpenseService.GetExpenseCodeByProjectTypeAndName(project);
            // then
            Assert.Equal(ExpenseType.INTERNAL_PROJECT_EXPENSE, result);
        }

        [Fact]
        public void Should_return_expense_type_A_if_project_is_external_and_name_is_project_A()
        {
            // given
            var project = new Project(ProjectType.EXTERNAL, "Project A");
            // when
            var result = ExpenseService.GetExpenseCodeByProjectTypeAndName(project);
            // then
            Assert.Equal(ExpenseType.EXPENSE_TYPE_A, result);
        }

        [Fact]
        public void Should_return_expense_type_B_if_project_is_external_and_name_is_project_B()
        {
            // given
            var project = new Project(ProjectType.EXTERNAL, "Project B");
            // when
            var result = ExpenseService.GetExpenseCodeByProjectTypeAndName(project);
            // then
            Assert.Equal(ExpenseType.EXPENSE_TYPE_B, result);
        }

        [Fact]
        public void Should_return_other_expense_type_if_project_is_external_and_has_other_name()
        {
            // given
            // when
            // then
        }

        [Fact]
        public void Should_throw_unexpected_project_exception_if_project_is_invalid()
        {
            // given
            // when
            // then
        }
    }
}
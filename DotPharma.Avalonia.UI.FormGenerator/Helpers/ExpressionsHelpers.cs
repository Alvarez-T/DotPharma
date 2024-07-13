using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using DotPharma.Avalonia.UI.FormGenerator.Exceptions;

namespace DotPharma.Avalonia.UI.FormGenerator.Helpers;

public static class ExpressionsHelpers
{
    private static MemberExpression ThrowIfNotPropertyMemberExpression(Expression expression)
    {
        if (expression is not MemberExpression { Member.MemberType: MemberTypes.Property } member)
            throw new InvalidMemberAccessExpression();

        return member;
    }

    public static void EnsureAccessPropertyExpression<T, TProperty>(Expression<Func<T, TProperty>> expression)
    {
        var member = ThrowIfNotPropertyMemberExpression(expression.Body);

        while (member.Expression is MemberExpression nestedMember)
            member = nestedMember;

        if (member.Expression is ParameterExpression parameterExpression &&
            parameterExpression.Type == typeof(T))
            return;

        throw new InvalidMemberAccessExpression();
    }

    public static string BuildMemberPath<T, TProperty>(Expression<Func<T, TProperty>> expression)
    {
        var memberExpression = ThrowIfNotPropertyMemberExpression(expression.Body);

        var pathBuilder = new StringBuilder();
        while (true)
        {
            pathBuilder.Append(memberExpression.Member.Name);

            switch (memberExpression.Expression)
            {
                case MemberExpression nestedMember:
                    pathBuilder.Append(".");
                    memberExpression = nestedMember;
                    continue;
                case ParameterExpression parameterExpression when
                    parameterExpression.Type == typeof(T):
                    return pathBuilder.ToString();
                default:
                    throw new InvalidMemberAccessExpression();
            }
        }
    }
}
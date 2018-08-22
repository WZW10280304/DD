using System;
using System.Linq;
using System.Linq.Expressions;
using CYJ.Utils.Extension.ReflectionExtension;

namespace CYJ.Utils.Extension.LinqExtension
{
    /// <summary>
    ///     Queryable 扩展
    /// </summary>
// ReSharper disable once CheckNamespace
    public static class QueryableExtensions
    {
        /// <summary>
        /// 筛选满足条件的项并给指定字段赋值
        /// </summary>
        /// <typeparam name="TAggregateRoot"></typeparam>
        /// <param name="tAggregateRoots"></param>
        /// <param name="tAggregateRoot"></param>
        /// <returns></returns>
        public static IQueryable<TAggregateRoot> Set<TAggregateRoot>(this IQueryable<TAggregateRoot> tAggregateRoots,
            Expression<Func<TAggregateRoot, TAggregateRoot>> tAggregateRoot) where TAggregateRoot : class, new()
        {
            if (tAggregateRoot != null)
            {
                if (!(tAggregateRoot.Body is MemberInitExpression exp) || exp.Bindings.Count == 0)
                    throw new Exception("无效的Lambda表达式");

                foreach (var binding in exp.Bindings)
                {
                    var ext = new EmitExtension<TAggregateRoot>();
                    ext.BuildEmitMethod(typeof(TAggregateRoot), binding.Member.Name);

                    if (!(binding is MemberAssignment memberAssignment))
                        throw new ArgumentException("表达式必须为MemberAssignment");

                    var memberExpression = memberAssignment.Expression;

                    ParameterExpression parameterExpression = null;

                    memberExpression.Visit((ParameterExpression p) =>
                    {
                        parameterExpression = p;
                        return p;
                    });

                    object value = null;

                    if (parameterExpression == null)
                        if (memberExpression.NodeType == ExpressionType.Constant)
                        {
                            if (!(memberExpression is ConstantExpression constantExpression))
                                throw new ArgumentException(
                                    "MemberAssignment expression 无效");
                            value = constantExpression.Value;
                        }
                        else
                        {
                            var lambda = Expression.Lambda(memberExpression, null);
                            value = lambda.Compile().DynamicInvoke();
                        }
                    else
                        throw new Exception("无效的Lambda表达式");

                    tAggregateRoots.ToList().ForEach(x => ext.EmitSetValue(x, value));
                }
            }
            else
            {
                throw new Exception("无效的Lambda表达式");
            }

            return tAggregateRoots;
        }
        /// <summary>
        /// 筛选满足条件的项并给指定字段赋值
        /// </summary>
        /// <typeparam name="TAggregateRoot"></typeparam>
        /// <typeparam name="TField"></typeparam>
        /// <param name="item"></param>
        /// <param name="field"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static IQueryable<TAggregateRoot> Set<TAggregateRoot, TField>(this IQueryable<TAggregateRoot> item,
            Expression<Func<TAggregateRoot, TField>> field, TField value) where TAggregateRoot : class, new()
        {
            if (field != null)
            {
                if (!(field.Body is MemberExpression exp) || field.Parameters.Count == 0) throw new Exception("无效的Lambda表达式");

                var ext = new EmitExtension<TAggregateRoot>();

                ext.BuildEmitMethod(typeof(TAggregateRoot), exp.Member.Name);
                item.ToList().ForEach(x => ext.EmitSetValue(x, value));
            }
            else
            {
                throw new Exception("无效的Lambda表达式");
            }

            return item;
        }
    }
}
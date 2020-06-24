// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

using System.Threading;
using System.Threading.Tasks;

namespace Nozomi.net.Services.Extensions
{
    /// <summary>
    /// Extension methods for ComputeExpression.
    /// </summary>
    public static partial class ComputeExpressionExtensions
    {
            /// <summary>
            /// Obtains all of the relevant compute expressions you own.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='index'>
            /// The 'page' of the list of results of every x items.
            /// </param>
            /// <param name='computeGuid'>
            /// Filter by the compute if needed.
            /// </param>
            public static object GET(this IComputeExpression operations, int index, string computeGuid = default(string))
            {
                return operations.GETAsync(index, computeGuid).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Obtains all of the relevant compute expressions you own.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='index'>
            /// The 'page' of the list of results of every x items.
            /// </param>
            /// <param name='computeGuid'>
            /// Filter by the compute if needed.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GETAsync(this IComputeExpression operations, int index, string computeGuid = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GETWithHttpMessagesAsync(index, computeGuid, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Obtains the specific compute expression.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='guid'>
            /// The Guid of the compute expression in question.
            /// </param>
            public static object GET1(this IComputeExpression operations, string guid)
            {
                return operations.GET1Async(guid).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Obtains the specific compute expression.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='guid'>
            /// The Guid of the compute expression in question.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GET1Async(this IComputeExpression operations, string guid, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GET1WithHttpMessagesAsync(guid, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

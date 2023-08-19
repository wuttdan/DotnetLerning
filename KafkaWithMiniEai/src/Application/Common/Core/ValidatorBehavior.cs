using Application.Query.NotifyAppointmentOrder;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Newtonsoft.Json.Linq;

namespace Application.Common.Core;

public class ValidatorBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
{
    private readonly IEnumerable<IValidator<TRequest>> _validators;
    public ValidatorBehavior(IEnumerable<IValidator<TRequest>> validators)
    {
        _validators = validators;
    }
    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        if (_validators.Any())
        {
            var context = new ValidationContext<TRequest>(request);
            var validationResults = await Task.WhenAll(_validators.Select(v => v.ValidateAsync(context, cancellationToken)));
            var failures = validationResults.SelectMany(r => r.Errors).Where(f => f != null).ToList();
            if (failures.Count != 0)
            {
                ////throw new FluentValidation.ValidationException(failures);
                var failure = failures.FirstOrDefault();
                if (failure != null)
                {
                    return CreateResponse<TRequest, TResponse>(request, failure);
                }
            } 
        }
        return await next();
    }

    private TResponseModel CreateResponse<TRequestModel, TResponseModel>(TRequestModel request, ValidationFailure failure)
    {
        ResponseBase res = null!;
        ////if (request is CommitNotifyAppointmentOrderRequestModel)
        ////{
        ////    var req = request as CommitNotifyAppointmentOrderRequestModel;
        ////    res = new CommitNotifyAppointmentOrderResponseModel
        ////    {
        ////        TRANSACTION_ID = req?.TransactionId,
        ////        RESULT_CODE = failure.ErrorCode,
        ////        RESULT_DESC = failure.ErrorMessage,
        ////        FIBRENET_ID = req?.FIBRENET_ID,
        ////        TYPE = req?.TYPE
        ////    }; 
        ////}
        Type type = request!.GetType();
        switch (type)
        {
            case Type _ when type == typeof(CommitNotifyAppointmentOrderRequestModel):
                var req = request as CommitNotifyAppointmentOrderRequestModel;
                res = req?.CreateResponse(failure.ErrorMessage, failure.ErrorCode) ?? new CommitNotifyAppointmentOrderResponseModel();
                break;
        }
        return (TResponseModel)Convert.ChangeType(res, typeof(TResponseModel));
    }
}
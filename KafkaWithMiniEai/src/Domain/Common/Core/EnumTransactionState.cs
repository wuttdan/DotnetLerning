using System.ComponentModel;

namespace Domain.Common.Core;

[DefaultValue(UNKNOW)]
public enum EnumTransactionState
{
    UNKNOW = -1,
    COMMIT = 0,
    DECOMPOSE = 1,
    WORKORDER = 2
}
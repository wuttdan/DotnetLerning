using Application.Common.Interfaces;
using Application.Common.Models.NotifyAppointmentOrder;
using Application.Query.NotifyAppointmentOrder;
using Application.UnitTests.Helper;
using FluentValidation.TestHelper;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.UnitTests.Validator;

public sealed class TestCommitNotifyAppointmentOrderValidator
{
	private CommitNotifyAppointmentOrderValidator validator;

	[SetUp]
	public void Setup()
	{
		// Arrange
		validator = new CommitNotifyAppointmentOrderValidator();
	}

	[Test]
    public void Should_Error_when_FibrenetId_is_NullOrEmpty()
    {

		// Arrange
		var req = new CommitNotifyAppointmentOrderRequestModel
		{
			FIBRENET_ID = "",
			TYPE = "",
			TYPE_OPER_DATE = "",
			MSG_SEQ_ID= "",
			MA_ORDER = null,
			INSTALL_ORDER = null
		};

		// Act
		var result = validator.TestValidate(req);

		// Assert
		result.ShouldHaveValidationErrorFor(req => req.FIBRENET_ID);
	}

	[Test]
	public void Should_Error_when_Type_is_NullOrEmpty()
	{

		// Arrange
		var req = new CommitNotifyAppointmentOrderRequestModel
		{
			FIBRENET_ID = "0000000000",
			TYPE = ""
		};

		// Act
		var result = validator.TestValidate(req);

		// Assert
		result.ShouldHaveValidationErrorFor(req => req.TYPE);
	}

	[Test]
	public void Should_Error_when_TypeOperDate_is_NullOrEmpty()
	{

		// Arrange
		var req = new CommitNotifyAppointmentOrderRequestModel
		{
			FIBRENET_ID = "0000000000",
			TYPE = "TYPE",
			TYPE_OPER_DATE = ""
		};

		// Act
		var result = validator.TestValidate(req);

		// Assert
		result.ShouldHaveValidationErrorFor(req => req.TYPE_OPER_DATE);
	}

	[Test]
	public void Should_Error_when_MsgSeqId_is_NullOrEmpty()
	{

		// Arrange
		var req = new CommitNotifyAppointmentOrderRequestModel
		{
			FIBRENET_ID = "0000000000",
			TYPE = "TYPE",
			TYPE_OPER_DATE = "YYYY-MM-DD HH:mm:ss",
			MSG_SEQ_ID = ""
		};

		// Act
		var result = validator.TestValidate(req);

		// Assert
		result.ShouldHaveValidationErrorFor(req => req.MSG_SEQ_ID);
	}

	[Test]
	public void Should_Error_when_MaOrderInstallOrder_is_NullOrEmpty()
	{

		// Arrange
		var req = new CommitNotifyAppointmentOrderRequestModel
		{
			FIBRENET_ID = "0000000000",
			TYPE = "TYPE",
			TYPE_OPER_DATE = "YYYY-MM-DD HH:mm:ss",
			MSG_SEQ_ID = "00",
			MA_ORDER = null,
			INSTALL_ORDER = null
		};

		// Act
		var result = validator.TestValidate(req);

		// Assert
		result.ShouldHaveAnyValidationError();
		Assert.IsFalse(result.IsValid);
        Assert.That("'INSTALL_ORDER' and 'MA_ORDER' should not be dual null or empty.", Is.EqualTo(result.Errors.Single().ErrorMessage));
		Assert.That("40007", Is.EqualTo(result.Errors.Single().ErrorCode));
	}

	[Test]
	public void Should_Pass_when_MaOrder_is_New()
	{

		// Arrange
		var req = new CommitNotifyAppointmentOrderRequestModel
		{
			FIBRENET_ID = "0000000000",
			TYPE = "TYPE",
			TYPE_OPER_DATE = "YYYY-MM-DD HH:mm:ss",
			MSG_SEQ_ID = "00",
			MA_ORDER = new NotifyAppointmentOrderMA()
		};

		// Act
		var result = validator.TestValidate(req);

		// Assert
		Assert.That(result.IsValid, Is.True);
	}

	[Test]
	public void Should_Pass_when_InstallOrder_is_New()
	{

		// Arrange
		var req = new CommitNotifyAppointmentOrderRequestModel
		{
			FIBRENET_ID = "0000000000",
			TYPE = "TYPE",
			TYPE_OPER_DATE = "YYYY-MM-DD HH:mm:ss",
			MSG_SEQ_ID = "00",
			INSTALL_ORDER = new NotifyAppointmentOrderInstall()
		};

		// Act
		var result = validator.TestValidate(req);

		// Assert
		Assert.That(result.IsValid, Is.True);
	}
}



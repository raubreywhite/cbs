/*---------------------------------------------------------------------------------------------
 *  Copyright (c) The International Federation of Red Cross and Red Crescent Societies. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using Events.NotificationGateway.Reporting.SMS;
using Machine.Specifications;
using Policies.Reporting.Notifications;

namespace Policies.Specs.Reporting.for_notifications.when_parsing_a_text_message_with_a_correctly_formated_aggregated_case_report.separated_by_hash
{
    [Subject("Notification")]
    public class when_report_has_a_negative_health_risk : given.text_message_received_events_containing_aggregated_case_report_separated_by_hash
    {        
        static readonly NotificationParser parser = new NotificationParser();
        static TextMessageReceived received_text_message;
        static NotificationParsingResult result;
        Establish context = () => received_text_message = text_message_received_with_negative_health_risk_id();
        
        Because of = () => result = parser.Parse(received_text_message);

        It should_not_be_a_valid_case_report = () => result.IsValid.ShouldBeFalse();
        It should_have_1_error_message = () => result.ErrorMessages.Count.ShouldEqual(1);
        It should_be_a_valid_format = () => result.IsInvalidFormat.ShouldBeFalse();
        It should_be_a_human_case_report = () => result.IsNonHumanCaseReport.ShouldBeFalse();
        It should_not_be_a_single_case_report = () => result.IsSingleCaseReport.ShouldBeFalse();
        It should_be_a_multiple_case_report = () => result.IsMultipleCaseReport.ShouldBeTrue();
    }
}
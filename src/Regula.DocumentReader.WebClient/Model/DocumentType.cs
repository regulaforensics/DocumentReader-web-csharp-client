/*
 * Regula Document Reader Web API
 *
 * Documents recognition as easy as reading two bytes.   # Clients: * [JavaScript](https://github.com/regulaforensics/DocumentReader-web-js-client) client for the browser and node.js based on axios * [Java](https://github.com/regulaforensics/DocumentReader-web-java-client) client compatible with jvm and android * [Python](https://github.com/regulaforensics/DocumentReader-web-python-client) 3.5+ client * [C#](https://github.com/regulaforensics/DocumentReader-web-csharp-client) client for .NET & .NET Core 
 *
 * The version of the OpenAPI document: 8.1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = Regula.DocumentReader.WebClient.Client.FileParameter;
using OpenAPIDateConverter = Regula.DocumentReader.WebClient.Client.OpenAPIDateConverter;

namespace Regula.DocumentReader.WebClient.Model
{
    /// <summary>
    /// Possible values for document types
    /// </summary>
    /// <value>Possible values for document types</value>
    public enum DocumentType
    {
        /// <summary>
        /// Enum NOT_DEFINED for value: 0
        /// </summary>
        NOT_DEFINED = 0,

        /// <summary>
        /// Enum PASSPORT for value: 11
        /// </summary>
        PASSPORT = 11,

        /// <summary>
        /// Enum IDENTITY_CARD for value: 12
        /// </summary>
        IDENTITY_CARD = 12,

        /// <summary>
        /// Enum DIPLOMATIC_PASSPORT for value: 13
        /// </summary>
        DIPLOMATIC_PASSPORT = 13,

        /// <summary>
        /// Enum SERVICE_PASSPORT for value: 14
        /// </summary>
        SERVICE_PASSPORT = 14,

        /// <summary>
        /// Enum SEAMANS_IDENTITY_DOCUMENT for value: 15
        /// </summary>
        SEAMANS_IDENTITY_DOCUMENT = 15,

        /// <summary>
        /// Enum IDENTITY_CARD_FOR_RESIDENCE for value: 16
        /// </summary>
        IDENTITY_CARD_FOR_RESIDENCE = 16,

        /// <summary>
        /// Enum TRAVEL_DOCUMENT for value: 17
        /// </summary>
        TRAVEL_DOCUMENT = 17,

        /// <summary>
        /// Enum NATIONAL_IDENTITY_CARD for value: 20
        /// </summary>
        NATIONAL_IDENTITY_CARD = 20,

        /// <summary>
        /// Enum SOCIAL_IDENTITY_CARD for value: 21
        /// </summary>
        SOCIAL_IDENTITY_CARD = 21,

        /// <summary>
        /// Enum ALIENS_IDENTITY_CARD for value: 22
        /// </summary>
        ALIENS_IDENTITY_CARD = 22,

        /// <summary>
        /// Enum PRIVILEGED_IDENTITY_CARD for value: 23
        /// </summary>
        PRIVILEGED_IDENTITY_CARD = 23,

        /// <summary>
        /// Enum RESIDENCE_PERMIT_IDENTITY_CARD for value: 24
        /// </summary>
        RESIDENCE_PERMIT_IDENTITY_CARD = 24,

        /// <summary>
        /// Enum ORIGIN_CARD for value: 25
        /// </summary>
        ORIGIN_CARD = 25,

        /// <summary>
        /// Enum EMERGENCY_PASSPORT for value: 26
        /// </summary>
        EMERGENCY_PASSPORT = 26,

        /// <summary>
        /// Enum ALIENS_PASSPORT for value: 27
        /// </summary>
        ALIENS_PASSPORT = 27,

        /// <summary>
        /// Enum ALTERNATIVE_IDENTITY_CARD for value: 28
        /// </summary>
        ALTERNATIVE_IDENTITY_CARD = 28,

        /// <summary>
        /// Enum VISA_ID2 for value: 29
        /// </summary>
        VISA_ID2 = 29,

        /// <summary>
        /// Enum VISA_ID3 for value: 30
        /// </summary>
        VISA_ID3 = 30,

        /// <summary>
        /// Enum AUTHORIZATION_CARD for value: 32
        /// </summary>
        AUTHORIZATION_CARD = 32,

        /// <summary>
        /// Enum BEGINNER_PERMIT for value: 33
        /// </summary>
        BEGINNER_PERMIT = 33,

        /// <summary>
        /// Enum BORDER_CROSSING_CARD for value: 34
        /// </summary>
        BORDER_CROSSING_CARD = 34,

        /// <summary>
        /// Enum CHAUFFEUR_LICENSE for value: 35
        /// </summary>
        CHAUFFEUR_LICENSE = 35,

        /// <summary>
        /// Enum CHAUFFEUR_LICENSE_UNDER_18 for value: 36
        /// </summary>
        CHAUFFEUR_LICENSE_UNDER_18 = 36,

        /// <summary>
        /// Enum CHAUFFEUR_LICENSE_UNDER_21 for value: 37
        /// </summary>
        CHAUFFEUR_LICENSE_UNDER_21 = 37,

        /// <summary>
        /// Enum COMMERCIAL_DRIVING_LICENSE for value: 38
        /// </summary>
        COMMERCIAL_DRIVING_LICENSE = 38,

        /// <summary>
        /// Enum COMMERCIAL_DRIVING_LICENSE_INSTRUCTIONAL_PERMIT for value: 39
        /// </summary>
        COMMERCIAL_DRIVING_LICENSE_INSTRUCTIONAL_PERMIT = 39,

        /// <summary>
        /// Enum COMMERCIAL_DRIVING_LICENSE_UNDER_18 for value: 40
        /// </summary>
        COMMERCIAL_DRIVING_LICENSE_UNDER_18 = 40,

        /// <summary>
        /// Enum COMMERCIAL_DRIVING_LICENSE_UNDER_21 for value: 41
        /// </summary>
        COMMERCIAL_DRIVING_LICENSE_UNDER_21 = 41,

        /// <summary>
        /// Enum COMMERCIAL_INSTRUCTION_PERMIT for value: 42
        /// </summary>
        COMMERCIAL_INSTRUCTION_PERMIT = 42,

        /// <summary>
        /// Enum COMMERCIAL_NEW_PERMIT for value: 43
        /// </summary>
        COMMERCIAL_NEW_PERMIT = 43,

        /// <summary>
        /// Enum CONCEALED_CARRY_LICENSE for value: 44
        /// </summary>
        CONCEALED_CARRY_LICENSE = 44,

        /// <summary>
        /// Enum CONCEALED_FIREARM_PERMIT for value: 45
        /// </summary>
        CONCEALED_FIREARM_PERMIT = 45,

        /// <summary>
        /// Enum CONDITIONAL_DRIVING_LICENSE for value: 46
        /// </summary>
        CONDITIONAL_DRIVING_LICENSE = 46,

        /// <summary>
        /// Enum DEPARTMENT_OF_VETERANS_AFFAIRS_IDENTITY_CARD for value: 47
        /// </summary>
        DEPARTMENT_OF_VETERANS_AFFAIRS_IDENTITY_CARD = 47,

        /// <summary>
        /// Enum DIPLOMATIC_DRIVING_LICENSE for value: 48
        /// </summary>
        DIPLOMATIC_DRIVING_LICENSE = 48,

        /// <summary>
        /// Enum DRIVING_LICENSE for value: 49
        /// </summary>
        DRIVING_LICENSE = 49,

        /// <summary>
        /// Enum DRIVING_LICENSE_INSTRUCTIONAL_PERMIT for value: 50
        /// </summary>
        DRIVING_LICENSE_INSTRUCTIONAL_PERMIT = 50,

        /// <summary>
        /// Enum DRIVING_LICENSE_INSTRUCTIONAL_PERMIT_UNDER_18 for value: 51
        /// </summary>
        DRIVING_LICENSE_INSTRUCTIONAL_PERMIT_UNDER_18 = 51,

        /// <summary>
        /// Enum DRIVING_LICENSE_INSTRUCTIONAL_PERMIT_UNDER_21 for value: 52
        /// </summary>
        DRIVING_LICENSE_INSTRUCTIONAL_PERMIT_UNDER_21 = 52,

        /// <summary>
        /// Enum DRIVING_LICENSE_LEARNERS_PERMIT for value: 53
        /// </summary>
        DRIVING_LICENSE_LEARNERS_PERMIT = 53,

        /// <summary>
        /// Enum DRIVING_LICENSE_LEARNERS_PERMIT_UNDER_18 for value: 54
        /// </summary>
        DRIVING_LICENSE_LEARNERS_PERMIT_UNDER_18 = 54,

        /// <summary>
        /// Enum DRIVING_LICENSE_LEARNERS_PERMIT_UNDER_21 for value: 55
        /// </summary>
        DRIVING_LICENSE_LEARNERS_PERMIT_UNDER_21 = 55,

        /// <summary>
        /// Enum DRIVING_LICENSE_NOVICE for value: 56
        /// </summary>
        DRIVING_LICENSE_NOVICE = 56,

        /// <summary>
        /// Enum DRIVING_LICENSE_NOVICE_UNDER_18 for value: 57
        /// </summary>
        DRIVING_LICENSE_NOVICE_UNDER_18 = 57,

        /// <summary>
        /// Enum DRIVING_LICENSE_NOVICE_UNDER_21 for value: 58
        /// </summary>
        DRIVING_LICENSE_NOVICE_UNDER_21 = 58,

        /// <summary>
        /// Enum DRIVING_LICENSE_REGISTERED_OFFENDER for value: 59
        /// </summary>
        DRIVING_LICENSE_REGISTERED_OFFENDER = 59,

        /// <summary>
        /// Enum DRIVING_LICENSE_RESTRICTED_UNDER_18 for value: 60
        /// </summary>
        DRIVING_LICENSE_RESTRICTED_UNDER_18 = 60,

        /// <summary>
        /// Enum DRIVING_LICENSE_RESTRICTED_UNDER_21 for value: 61
        /// </summary>
        DRIVING_LICENSE_RESTRICTED_UNDER_21 = 61,

        /// <summary>
        /// Enum DRIVING_LICENSE_TEMPORARY_VISITOR for value: 62
        /// </summary>
        DRIVING_LICENSE_TEMPORARY_VISITOR = 62,

        /// <summary>
        /// Enum DRIVING_LICENSE_TEMPORARY_VISITOR_UNDER_18 for value: 63
        /// </summary>
        DRIVING_LICENSE_TEMPORARY_VISITOR_UNDER_18 = 63,

        /// <summary>
        /// Enum DRIVING_LICENSE_TEMPORARY_VISITOR_UNDER_21 for value: 64
        /// </summary>
        DRIVING_LICENSE_TEMPORARY_VISITOR_UNDER_21 = 64,

        /// <summary>
        /// Enum DRIVING_LICENSE_UNDER_18 for value: 65
        /// </summary>
        DRIVING_LICENSE_UNDER_18 = 65,

        /// <summary>
        /// Enum DRIVING_LICENSE_UNDER_21 for value: 66
        /// </summary>
        DRIVING_LICENSE_UNDER_21 = 66,

        /// <summary>
        /// Enum EMPLOYMENT_DRIVING_PERMIT for value: 67
        /// </summary>
        EMPLOYMENT_DRIVING_PERMIT = 67,

        /// <summary>
        /// Enum ENHANCED_CHAUFFEUR_LICENSE for value: 68
        /// </summary>
        ENHANCED_CHAUFFEUR_LICENSE = 68,

        /// <summary>
        /// Enum ENHANCED_CHAUFFEUR_LICENSE_UNDER_18 for value: 69
        /// </summary>
        ENHANCED_CHAUFFEUR_LICENSE_UNDER_18 = 69,

        /// <summary>
        /// Enum ENHANCED_CHAUFFEUR_LICENSE_UNDER_21 for value: 70
        /// </summary>
        ENHANCED_CHAUFFEUR_LICENSE_UNDER_21 = 70,

        /// <summary>
        /// Enum ENHANCED_COMMERCIAL_DRIVING_LICENSE for value: 71
        /// </summary>
        ENHANCED_COMMERCIAL_DRIVING_LICENSE = 71,

        /// <summary>
        /// Enum ENHANCED_DRIVING_LICENSE for value: 72
        /// </summary>
        ENHANCED_DRIVING_LICENSE = 72,

        /// <summary>
        /// Enum ENHANCED_DRIVING_LICENSE_UNDER_18 for value: 73
        /// </summary>
        ENHANCED_DRIVING_LICENSE_UNDER_18 = 73,

        /// <summary>
        /// Enum ENHANCED_DRIVING_LICENSE_UNDER_21 for value: 74
        /// </summary>
        ENHANCED_DRIVING_LICENSE_UNDER_21 = 74,

        /// <summary>
        /// Enum ENHANCED_IDENTITY_CARD for value: 75
        /// </summary>
        ENHANCED_IDENTITY_CARD = 75,

        /// <summary>
        /// Enum ENHANCED_IDENTITY_CARD_UNDER_18 for value: 76
        /// </summary>
        ENHANCED_IDENTITY_CARD_UNDER_18 = 76,

        /// <summary>
        /// Enum ENHANCED_IDENTITY_CARD_UNDER_21 for value: 77
        /// </summary>
        ENHANCED_IDENTITY_CARD_UNDER_21 = 77,

        /// <summary>
        /// Enum ENHANCED_OPERATORS_LICENSE for value: 78
        /// </summary>
        ENHANCED_OPERATORS_LICENSE = 78,

        /// <summary>
        /// Enum FIREARMS_PERMIT for value: 79
        /// </summary>
        FIREARMS_PERMIT = 79,

        /// <summary>
        /// Enum FULL_PROVISIONAL_LICENSE for value: 80
        /// </summary>
        FULL_PROVISIONAL_LICENSE = 80,

        /// <summary>
        /// Enum FULL_PROVISIONAL_LICENSE_UNDER_18 for value: 81
        /// </summary>
        FULL_PROVISIONAL_LICENSE_UNDER_18 = 81,

        /// <summary>
        /// Enum FULL_PROVISIONAL_LICENSE_UNDER_21 for value: 82
        /// </summary>
        FULL_PROVISIONAL_LICENSE_UNDER_21 = 82,

        /// <summary>
        /// Enum GENEVA_CONVENTIONS_IDENTITY_CARD for value: 83
        /// </summary>
        GENEVA_CONVENTIONS_IDENTITY_CARD = 83,

        /// <summary>
        /// Enum GRADUATED_DRIVING_LICENSE_UNDER_18 for value: 84
        /// </summary>
        GRADUATED_DRIVING_LICENSE_UNDER_18 = 84,

        /// <summary>
        /// Enum GRADUATED_DRIVING_LICENSE_UNDER_21 for value: 85
        /// </summary>
        GRADUATED_DRIVING_LICENSE_UNDER_21 = 85,

        /// <summary>
        /// Enum GRADUATED_INSTRUCTION_PERMIT_UNDER_18 for value: 86
        /// </summary>
        GRADUATED_INSTRUCTION_PERMIT_UNDER_18 = 86,

        /// <summary>
        /// Enum GRADUATED_INSTRUCTION_PERMIT_UNDER_21 for value: 87
        /// </summary>
        GRADUATED_INSTRUCTION_PERMIT_UNDER_21 = 87,

        /// <summary>
        /// Enum GRADUATED_LICENSE_UNDER_18 for value: 88
        /// </summary>
        GRADUATED_LICENSE_UNDER_18 = 88,

        /// <summary>
        /// Enum GRADUATED_LICENSE_UNDER_21 for value: 89
        /// </summary>
        GRADUATED_LICENSE_UNDER_21 = 89,

        /// <summary>
        /// Enum HANDGUN_CARRY_PERMIT for value: 90
        /// </summary>
        HANDGUN_CARRY_PERMIT = 90,

        /// <summary>
        /// Enum IDENTITY_AND_PRIVILEGE_CARD for value: 91
        /// </summary>
        IDENTITY_AND_PRIVILEGE_CARD = 91,

        /// <summary>
        /// Enum IDENTITY_CARD_MOBILITY_IMPAIRED for value: 92
        /// </summary>
        IDENTITY_CARD_MOBILITY_IMPAIRED = 92,

        /// <summary>
        /// Enum IDENTITY_CARD_REGISTERED_OFFENDER for value: 93
        /// </summary>
        IDENTITY_CARD_REGISTERED_OFFENDER = 93,

        /// <summary>
        /// Enum IDENTITY_CARD_TEMPORARY_VISITOR for value: 94
        /// </summary>
        IDENTITY_CARD_TEMPORARY_VISITOR = 94,

        /// <summary>
        /// Enum IDENTITY_CARD_TEMPORARY_VISITOR_UNDER_18 for value: 95
        /// </summary>
        IDENTITY_CARD_TEMPORARY_VISITOR_UNDER_18 = 95,

        /// <summary>
        /// Enum IDENTITY_CARD_TEMPORARY_VISITOR_UNDER_21 for value: 96
        /// </summary>
        IDENTITY_CARD_TEMPORARY_VISITOR_UNDER_21 = 96,

        /// <summary>
        /// Enum IDENTITY_CARD_UNDER_18 for value: 97
        /// </summary>
        IDENTITY_CARD_UNDER_18 = 97,

        /// <summary>
        /// Enum IDENTITY_CARD_UNDER_21 for value: 98
        /// </summary>
        IDENTITY_CARD_UNDER_21 = 98,

        /// <summary>
        /// Enum OTHER for value: 99
        /// </summary>
        OTHER = 99,

        /// <summary>
        /// Enum IGNITION_INTERLOCK_PERMIT for value: 100
        /// </summary>
        IGNITION_INTERLOCK_PERMIT = 100,

        /// <summary>
        /// Enum IMMIGRANT_VISA for value: 101
        /// </summary>
        IMMIGRANT_VISA = 101,

        /// <summary>
        /// Enum INSTRUCTION_PERMIT for value: 102
        /// </summary>
        INSTRUCTION_PERMIT = 102,

        /// <summary>
        /// Enum INSTRUCTION_PERMIT_UNDER_18 for value: 103
        /// </summary>
        INSTRUCTION_PERMIT_UNDER_18 = 103,

        /// <summary>
        /// Enum INSTRUCTION_PERMIT_UNDER_21 for value: 104
        /// </summary>
        INSTRUCTION_PERMIT_UNDER_21 = 104,

        /// <summary>
        /// Enum INTERIM_DRIVING_LICENSE for value: 105
        /// </summary>
        INTERIM_DRIVING_LICENSE = 105,

        /// <summary>
        /// Enum INTERIM_IDENTITY_CARD for value: 106
        /// </summary>
        INTERIM_IDENTITY_CARD = 106,

        /// <summary>
        /// Enum INTERMEDIATE_DRIVING_LICENSE for value: 107
        /// </summary>
        INTERMEDIATE_DRIVING_LICENSE = 107,

        /// <summary>
        /// Enum INTERMEDIATE_DRIVING_LICENSE_UNDER_18 for value: 108
        /// </summary>
        INTERMEDIATE_DRIVING_LICENSE_UNDER_18 = 108,

        /// <summary>
        /// Enum INTERMEDIATE_DRIVING_LICENSE_UNDER_21 for value: 109
        /// </summary>
        INTERMEDIATE_DRIVING_LICENSE_UNDER_21 = 109,

        /// <summary>
        /// Enum JUNIOR_DRIVING_LICENSE for value: 110
        /// </summary>
        JUNIOR_DRIVING_LICENSE = 110,

        /// <summary>
        /// Enum LEARNER_INSTRUCTIONAL_PERMIT for value: 111
        /// </summary>
        LEARNER_INSTRUCTIONAL_PERMIT = 111,

        /// <summary>
        /// Enum LEARNER_LICENSE for value: 112
        /// </summary>
        LEARNER_LICENSE = 112,

        /// <summary>
        /// Enum LEARNER_LICENSE_UNDER_18 for value: 113
        /// </summary>
        LEARNER_LICENSE_UNDER_18 = 113,

        /// <summary>
        /// Enum LEARNER_LICENSE_UNDER_21 for value: 114
        /// </summary>
        LEARNER_LICENSE_UNDER_21 = 114,

        /// <summary>
        /// Enum LEARNER_PERMIT for value: 115
        /// </summary>
        LEARNER_PERMIT = 115,

        /// <summary>
        /// Enum LEARNER_PERMIT_UNDER_18 for value: 116
        /// </summary>
        LEARNER_PERMIT_UNDER_18 = 116,

        /// <summary>
        /// Enum LEARNER_PERMIT_UNDER_21 for value: 117
        /// </summary>
        LEARNER_PERMIT_UNDER_21 = 117,

        /// <summary>
        /// Enum LIMITED_LICENSE for value: 118
        /// </summary>
        LIMITED_LICENSE = 118,

        /// <summary>
        /// Enum LIMITED_PERMIT for value: 119
        /// </summary>
        LIMITED_PERMIT = 119,

        /// <summary>
        /// Enum LIMITED_TERM_DRIVING_LICENSE for value: 120
        /// </summary>
        LIMITED_TERM_DRIVING_LICENSE = 120,

        /// <summary>
        /// Enum LIMITED_TERM_IDENTITY_CARD for value: 121
        /// </summary>
        LIMITED_TERM_IDENTITY_CARD = 121,

        /// <summary>
        /// Enum LIQUOR_IDENTITY_CARD for value: 122
        /// </summary>
        LIQUOR_IDENTITY_CARD = 122,

        /// <summary>
        /// Enum NEW_PERMIT for value: 123
        /// </summary>
        NEW_PERMIT = 123,

        /// <summary>
        /// Enum NEW_PERMIT_UNDER_18 for value: 124
        /// </summary>
        NEW_PERMIT_UNDER_18 = 124,

        /// <summary>
        /// Enum NEW_PERMIT_UNDER_21 for value: 125
        /// </summary>
        NEW_PERMIT_UNDER_21 = 125,

        /// <summary>
        /// Enum NON_US_CITIZEN_DRIVING_LICENSE for value: 126
        /// </summary>
        NON_US_CITIZEN_DRIVING_LICENSE = 126,

        /// <summary>
        /// Enum OCCUPATIONAL_DRIVING_LICENSE for value: 127
        /// </summary>
        OCCUPATIONAL_DRIVING_LICENSE = 127,

        /// <summary>
        /// Enum ONEIDA_TRIBE_OF_INDIANS_IDENTITY_CARD for value: 128
        /// </summary>
        ONEIDA_TRIBE_OF_INDIANS_IDENTITY_CARD = 128,

        /// <summary>
        /// Enum OPERATOR_LICENSE for value: 129
        /// </summary>
        OPERATOR_LICENSE = 129,

        /// <summary>
        /// Enum OPERATOR_LICENSE_UNDER_18 for value: 130
        /// </summary>
        OPERATOR_LICENSE_UNDER_18 = 130,

        /// <summary>
        /// Enum OPERATOR_LICENSE_UNDER_21 for value: 131
        /// </summary>
        OPERATOR_LICENSE_UNDER_21 = 131,

        /// <summary>
        /// Enum PERMANENT_DRIVING_LICENSE for value: 132
        /// </summary>
        PERMANENT_DRIVING_LICENSE = 132,

        /// <summary>
        /// Enum PERMIT_TO_REENTER for value: 133
        /// </summary>
        PERMIT_TO_REENTER = 133,

        /// <summary>
        /// Enum PROBATIONARY_AUTO_LICENSE for value: 134
        /// </summary>
        PROBATIONARY_AUTO_LICENSE = 134,

        /// <summary>
        /// Enum PROBATIONARY_DRIVING_LICENSE_UNDER_18 for value: 135
        /// </summary>
        PROBATIONARY_DRIVING_LICENSE_UNDER_18 = 135,

        /// <summary>
        /// Enum PROBATIONARY_DRIVING_LICENSE_UNDER_21 for value: 136
        /// </summary>
        PROBATIONARY_DRIVING_LICENSE_UNDER_21 = 136,

        /// <summary>
        /// Enum PROBATIONARY_VEHICLE_SALES_PERSON_LICENSE for value: 137
        /// </summary>
        PROBATIONARY_VEHICLE_SALES_PERSON_LICENSE = 137,

        /// <summary>
        /// Enum PROVISIONAL_DRIVING_LICENSE for value: 138
        /// </summary>
        PROVISIONAL_DRIVING_LICENSE = 138,

        /// <summary>
        /// Enum PROVISIONAL_DRIVING_LICENSE_UNDER_18 for value: 139
        /// </summary>
        PROVISIONAL_DRIVING_LICENSE_UNDER_18 = 139,

        /// <summary>
        /// Enum PROVISIONAL_DRIVING_LICENSE_UNDER_21 for value: 140
        /// </summary>
        PROVISIONAL_DRIVING_LICENSE_UNDER_21 = 140,

        /// <summary>
        /// Enum PROVISIONAL_LICENSE for value: 141
        /// </summary>
        PROVISIONAL_LICENSE = 141,

        /// <summary>
        /// Enum PROVISIONAL_LICENSE_UNDER_18 for value: 142
        /// </summary>
        PROVISIONAL_LICENSE_UNDER_18 = 142,

        /// <summary>
        /// Enum PROVISIONAL_LICENSE_UNDER_21 for value: 143
        /// </summary>
        PROVISIONAL_LICENSE_UNDER_21 = 143,

        /// <summary>
        /// Enum PUBLIC_PASSENGER_CHAUFFEUR_LICENSE for value: 144
        /// </summary>
        PUBLIC_PASSENGER_CHAUFFEUR_LICENSE = 144,

        /// <summary>
        /// Enum RACING_AND_GAMING_COMISSION_CARD for value: 145
        /// </summary>
        RACING_AND_GAMING_COMISSION_CARD = 145,

        /// <summary>
        /// Enum REFUGEE_TRAVEL_DOCUMENT for value: 146
        /// </summary>
        REFUGEE_TRAVEL_DOCUMENT = 146,

        /// <summary>
        /// Enum RENEWAL_PERMIT for value: 147
        /// </summary>
        RENEWAL_PERMIT = 147,

        /// <summary>
        /// Enum RESTRICTED_COMMERCIAL_DRIVER_LICENSE for value: 148
        /// </summary>
        RESTRICTED_COMMERCIAL_DRIVER_LICENSE = 148,

        /// <summary>
        /// Enum RESTRICTED_DRIVER_LICENSE for value: 149
        /// </summary>
        RESTRICTED_DRIVER_LICENSE = 149,

        /// <summary>
        /// Enum RESTRICTED_PERMIT for value: 150
        /// </summary>
        RESTRICTED_PERMIT = 150,

        /// <summary>
        /// Enum SEASONAL_PERMIT for value: 151
        /// </summary>
        SEASONAL_PERMIT = 151,

        /// <summary>
        /// Enum SEASONAL_RESIDENT_IDENTITY_CARD for value: 152
        /// </summary>
        SEASONAL_RESIDENT_IDENTITY_CARD = 152,

        /// <summary>
        /// Enum SEASONAL_CITIZEN_IDENTITY_CARD for value: 153
        /// </summary>
        SEASONAL_CITIZEN_IDENTITY_CARD = 153,

        /// <summary>
        /// Enum SEX_OFFENDER for value: 154
        /// </summary>
        SEX_OFFENDER = 154,

        /// <summary>
        /// Enum SOCIAL_SECURITY_CARD for value: 155
        /// </summary>
        SOCIAL_SECURITY_CARD = 155,

        /// <summary>
        /// Enum TEMPORARY_DRIVING_LICENSE for value: 156
        /// </summary>
        TEMPORARY_DRIVING_LICENSE = 156,

        /// <summary>
        /// Enum TEMPORARY_DRIVING_LICENSE_UNDER_18 for value: 157
        /// </summary>
        TEMPORARY_DRIVING_LICENSE_UNDER_18 = 157,

        /// <summary>
        /// Enum TEMPORARY_DRIVING_LICENSE_UNDER_21 for value: 158
        /// </summary>
        TEMPORARY_DRIVING_LICENSE_UNDER_21 = 158,

        /// <summary>
        /// Enum TEMPORARY_IDENTITY_CARD for value: 159
        /// </summary>
        TEMPORARY_IDENTITY_CARD = 159,

        /// <summary>
        /// Enum TEMPORARY_INSTRUCTION_PERMIT_IDENTITY_CARD for value: 160
        /// </summary>
        TEMPORARY_INSTRUCTION_PERMIT_IDENTITY_CARD = 160,

        /// <summary>
        /// Enum TEMPORARY_INSTRUCTION_PERMIT_IDENTITY_CARD_UNDER_18 for value: 161
        /// </summary>
        TEMPORARY_INSTRUCTION_PERMIT_IDENTITY_CARD_UNDER_18 = 161,

        /// <summary>
        /// Enum TEMPORARY_INSTRUCTION_PERMIT_IDENTITY_CARD_UNDER_21 for value: 162
        /// </summary>
        TEMPORARY_INSTRUCTION_PERMIT_IDENTITY_CARD_UNDER_21 = 162,

        /// <summary>
        /// Enum TEMPORARY_VISITOR_DRIVING_LICENSE for value: 163
        /// </summary>
        TEMPORARY_VISITOR_DRIVING_LICENSE = 163,

        /// <summary>
        /// Enum TEMPORARY_VISITOR_DRIVING_LICENSE_UNDER_18 for value: 164
        /// </summary>
        TEMPORARY_VISITOR_DRIVING_LICENSE_UNDER_18 = 164,

        /// <summary>
        /// Enum TEMPORARY_VISITOR_DRIVING_LICENSE_UNDER_21 for value: 165
        /// </summary>
        TEMPORARY_VISITOR_DRIVING_LICENSE_UNDER_21 = 165,

        /// <summary>
        /// Enum UNIFORMED_SERVICES_IDENTITY_CARD for value: 166
        /// </summary>
        UNIFORMED_SERVICES_IDENTITY_CARD = 166,

        /// <summary>
        /// Enum VEHICLE_SALES_PERSON_LICENSE for value: 167
        /// </summary>
        VEHICLE_SALES_PERSON_LICENSE = 167,

        /// <summary>
        /// Enum WORKER_IDENTIFICATION_CREDENTIAL for value: 168
        /// </summary>
        WORKER_IDENTIFICATION_CREDENTIAL = 168,

        /// <summary>
        /// Enum COMMERCIAL_DRIVING_LICENSE_NOVICE for value: 169
        /// </summary>
        COMMERCIAL_DRIVING_LICENSE_NOVICE = 169,

        /// <summary>
        /// Enum COMMERCIAL_DRIVING_LICENSE_NOVICE_UNDER_18 for value: 170
        /// </summary>
        COMMERCIAL_DRIVING_LICENSE_NOVICE_UNDER_18 = 170,

        /// <summary>
        /// Enum COMMERCIAL_DRIVING_LICENSE_NOVICE_UNDER_21 for value: 171
        /// </summary>
        COMMERCIAL_DRIVING_LICENSE_NOVICE_UNDER_21 = 171,

        /// <summary>
        /// Enum PASSPORT_CARD for value: 172
        /// </summary>
        PASSPORT_CARD = 172,

        /// <summary>
        /// Enum PASSPORT_RESIDENT_CARD for value: 173
        /// </summary>
        PASSPORT_RESIDENT_CARD = 173,

        /// <summary>
        /// Enum PERSONAL_IDENTIFICATION_VERIFICATION for value: 174
        /// </summary>
        PERSONAL_IDENTIFICATION_VERIFICATION = 174,

        /// <summary>
        /// Enum TEMPORARY_OPERATOR_LICENSE for value: 175
        /// </summary>
        TEMPORARY_OPERATOR_LICENSE = 175,

        /// <summary>
        /// Enum DRIVING_LICENSE_UNDER_19 for value: 176
        /// </summary>
        DRIVING_LICENSE_UNDER_19 = 176,

        /// <summary>
        /// Enum IDENTITY_CARD_UNDER_19 for value: 177
        /// </summary>
        IDENTITY_CARD_UNDER_19 = 177,

        /// <summary>
        /// Enum VISA for value: 178
        /// </summary>
        VISA = 178,

        /// <summary>
        /// Enum TEMPORARY_PASSPORT for value: 179
        /// </summary>
        TEMPORARY_PASSPORT = 179,

        /// <summary>
        /// Enum VOTING_CARD for value: 180
        /// </summary>
        VOTING_CARD = 180,

        /// <summary>
        /// Enum HEALTH_CARD for value: 181
        /// </summary>
        HEALTH_CARD = 181,

        /// <summary>
        /// Enum CERTIFICATE_OF_CITIZENSHIP for value: 182
        /// </summary>
        CERTIFICATE_OF_CITIZENSHIP = 182,

        /// <summary>
        /// Enum ADDRESS_CARD for value: 183
        /// </summary>
        ADDRESS_CARD = 183,

        /// <summary>
        /// Enum AIRPORT_IMMIGRATION_CARD for value: 184
        /// </summary>
        AIRPORT_IMMIGRATION_CARD = 184,

        /// <summary>
        /// Enum ALIEN_REGISTRATION_CARD for value: 185
        /// </summary>
        ALIEN_REGISTRATION_CARD = 185,

        /// <summary>
        /// Enum APEH_CARD for value: 186
        /// </summary>
        APEH_CARD = 186,

        /// <summary>
        /// Enum COUPON_TO_DRIVING_LICENSE for value: 187
        /// </summary>
        COUPON_TO_DRIVING_LICENSE = 187,

        /// <summary>
        /// Enum CREW_MEMBER_CERTIFICATE for value: 188
        /// </summary>
        CREW_MEMBER_CERTIFICATE = 188,

        /// <summary>
        /// Enum DOCUMENT_FOR_RETURN for value: 189
        /// </summary>
        DOCUMENT_FOR_RETURN = 189,

        /// <summary>
        /// Enum E_CARD for value: 190
        /// </summary>
        E_CARD = 190,

        /// <summary>
        /// Enum EMPLOYMENT_CARD for value: 191
        /// </summary>
        EMPLOYMENT_CARD = 191,

        /// <summary>
        /// Enum HKSAR_IMMIGRATION_FORM for value: 192
        /// </summary>
        HKSAR_IMMIGRATION_FORM = 192,

        /// <summary>
        /// Enum IMMIGRANT_CARD for value: 193
        /// </summary>
        IMMIGRANT_CARD = 193,

        /// <summary>
        /// Enum LABOUR_CARD for value: 194
        /// </summary>
        LABOUR_CARD = 194,

        /// <summary>
        /// Enum LAISSEZ_PASSER for value: 195
        /// </summary>
        LAISSEZ_PASSER = 195,

        /// <summary>
        /// Enum LAWYER_IDENTITY_CERTIFICATE for value: 196
        /// </summary>
        LAWYER_IDENTITY_CERTIFICATE = 196,

        /// <summary>
        /// Enum LICENSE_CARD for value: 197
        /// </summary>
        LICENSE_CARD = 197,

        /// <summary>
        /// Enum PASSPORT_STATELESS for value: 198
        /// </summary>
        PASSPORT_STATELESS = 198,

        /// <summary>
        /// Enum PASSPORT_CHILD for value: 199
        /// </summary>
        PASSPORT_CHILD = 199,

        /// <summary>
        /// Enum PASSPORT_CONSULAR for value: 200
        /// </summary>
        PASSPORT_CONSULAR = 200,

        /// <summary>
        /// Enum PASSPORT_DIPLOMATIC_SERVICE for value: 201
        /// </summary>
        PASSPORT_DIPLOMATIC_SERVICE = 201,

        /// <summary>
        /// Enum PASSPORT_OFFICIAL for value: 202
        /// </summary>
        PASSPORT_OFFICIAL = 202,

        /// <summary>
        /// Enum PASSPORT_PROVISIONAL for value: 203
        /// </summary>
        PASSPORT_PROVISIONAL = 203,

        /// <summary>
        /// Enum PASSPORT_SPECIAL for value: 204
        /// </summary>
        PASSPORT_SPECIAL = 204,

        /// <summary>
        /// Enum PERMISSION_TO_THE_LOCAL_BORDER_TRAFFIC for value: 205
        /// </summary>
        PERMISSION_TO_THE_LOCAL_BORDER_TRAFFIC = 205,

        /// <summary>
        /// Enum REGISTRATION_CERTIFICATE for value: 206
        /// </summary>
        REGISTRATION_CERTIFICATE = 206,

        /// <summary>
        /// Enum SEDESOL_CARD for value: 207
        /// </summary>
        SEDESOL_CARD = 207,

        /// <summary>
        /// Enum SOCIAL_CARD for value: 208
        /// </summary>
        SOCIAL_CARD = 208,

        /// <summary>
        /// Enum TB_CARD for value: 209
        /// </summary>
        TB_CARD = 209,

        /// <summary>
        /// Enum VEHICLE_PASSPORT for value: 210
        /// </summary>
        VEHICLE_PASSPORT = 210,

        /// <summary>
        /// Enum W_DOCUMENT for value: 211
        /// </summary>
        W_DOCUMENT = 211,

        /// <summary>
        /// Enum DIPLOMATIC_IDENTITY_CARD for value: 212
        /// </summary>
        DIPLOMATIC_IDENTITY_CARD = 212,

        /// <summary>
        /// Enum CONSULAR_IDENTITY_CARD for value: 213
        /// </summary>
        CONSULAR_IDENTITY_CARD = 213,

        /// <summary>
        /// Enum INCOME_TAX_CARD for value: 214
        /// </summary>
        INCOME_TAX_CARD = 214,

        /// <summary>
        /// Enum RESIDENCE_PERMIT for value: 215
        /// </summary>
        RESIDENCE_PERMIT = 215,

        /// <summary>
        /// Enum DOCUMENT_OF_IDENTITY for value: 216
        /// </summary>
        DOCUMENT_OF_IDENTITY = 216,

        /// <summary>
        /// Enum BORDER_CROSSING_PERMIT for value: 217
        /// </summary>
        BORDER_CROSSING_PERMIT = 217,

        /// <summary>
        /// Enum PASSPORT_LIMITED_VALIDITY for value: 218
        /// </summary>
        PASSPORT_LIMITED_VALIDITY = 218,

        /// <summary>
        /// Enum SIM_CARD for value: 219
        /// </summary>
        SIM_CARD = 219,

        /// <summary>
        /// Enum TAX_CARD for value: 220
        /// </summary>
        TAX_CARD = 220,

        /// <summary>
        /// Enum COMPANY_CARD for value: 221
        /// </summary>
        COMPANY_CARD = 221,

        /// <summary>
        /// Enum DOMESTIC_PASSPORT for value: 222
        /// </summary>
        DOMESTIC_PASSPORT = 222,

        /// <summary>
        /// Enum IDENTITY_CERTIFICATE for value: 223
        /// </summary>
        IDENTITY_CERTIFICATE = 223,

        /// <summary>
        /// Enum RESIDENT_ID_CARD for value: 224
        /// </summary>
        RESIDENT_ID_CARD = 224,

        /// <summary>
        /// Enum ARMED_FORCES_IDENTITY_CARD for value: 225
        /// </summary>
        ARMED_FORCES_IDENTITY_CARD = 225,

        /// <summary>
        /// Enum PROFESSIONAL_CARD for value: 226
        /// </summary>
        PROFESSIONAL_CARD = 226,

        /// <summary>
        /// Enum REGISTRATION_STAMP for value: 227
        /// </summary>
        REGISTRATION_STAMP = 227,

        /// <summary>
        /// Enum DRIVER_CARD for value: 228
        /// </summary>
        DRIVER_CARD = 228,

        /// <summary>
        /// Enum DRIVER_TRAINING_CERTIFICATE for value: 229
        /// </summary>
        DRIVER_TRAINING_CERTIFICATE = 229,

        /// <summary>
        /// Enum QUALIFICATION_DRIVING_LICENSE for value: 230
        /// </summary>
        QUALIFICATION_DRIVING_LICENSE = 230,

        /// <summary>
        /// Enum MEMBERSHIP_CARD for value: 231
        /// </summary>
        MEMBERSHIP_CARD = 231,

        /// <summary>
        /// Enum PUBLIC_VEHICLE_DRIVER_AUTHORITY_CARD for value: 232
        /// </summary>
        PUBLIC_VEHICLE_DRIVER_AUTHORITY_CARD = 232,

        /// <summary>
        /// Enum MARINE_LICENSE for value: 233
        /// </summary>
        MARINE_LICENSE = 233,

        /// <summary>
        /// Enum TEMPORARY_LEARNER_LICENSE for value: 234
        /// </summary>
        TEMPORARY_LEARNER_LICENSE = 234,

        /// <summary>
        /// Enum TEMPORARY_COMMERCIAL_DRIVING_LICENSE for value: 235
        /// </summary>
        TEMPORARY_COMMERCIAL_DRIVING_LICENSE = 235,

        /// <summary>
        /// Enum INTERIM_INSTRUCTIONAL_PERMIT for value: 236
        /// </summary>
        INTERIM_INSTRUCTIONAL_PERMIT = 236,

        /// <summary>
        /// Enum CERTIFICATE_OF_COMPETENCY for value: 237
        /// </summary>
        CERTIFICATE_OF_COMPETENCY = 237,

        /// <summary>
        /// Enum CERTIFICATE_OF_PROFICIENCY for value: 238
        /// </summary>
        CERTIFICATE_OF_PROFICIENCY = 238,

        /// <summary>
        /// Enum TRADE_LICENSE for value: 239
        /// </summary>
        TRADE_LICENSE = 239,

        /// <summary>
        /// Enum PASSPORT_PAGE for value: 240
        /// </summary>
        PASSPORT_PAGE = 240,

        /// <summary>
        /// Enum INVOICE for value: 241
        /// </summary>
        INVOICE = 241,

        /// <summary>
        /// Enum PASSENGER_LOCATOR_FORM for value: 242
        /// </summary>
        PASSENGER_LOCATOR_FORM = 242
    }

}

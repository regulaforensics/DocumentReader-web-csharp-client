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
    /// Enumeration contains identifiers which determinate the single document element authenticity check outcome reason: https://docs.regulaforensics.com/develop/doc-reader-sdk/web-service/development/enums/check-diagnose/
    /// </summary>
    /// <value>Enumeration contains identifiers which determinate the single document element authenticity check outcome reason: https://docs.regulaforensics.com/develop/doc-reader-sdk/web-service/development/enums/check-diagnose/</value>
    public enum CheckDiagnose
    {
        /// <summary>
        /// Enum UNKNOWN for value: 0
        /// </summary>
        UNKNOWN = 0,

        /// <summary>
        /// Enum PASS for value: 1
        /// </summary>
        PASS = 1,

        /// <summary>
        /// Enum INVALID_INPUT_DATA for value: 2
        /// </summary>
        INVALID_INPUT_DATA = 2,

        /// <summary>
        /// Enum INTERNAL_ERROR for value: 3
        /// </summary>
        INTERNAL_ERROR = 3,

        /// <summary>
        /// Enum EXCEPTION_IN_MODULE for value: 4
        /// </summary>
        EXCEPTION_IN_MODULE = 4,

        /// <summary>
        /// Enum UNCERTAIN_VERIFICATION for value: 5
        /// </summary>
        UNCERTAIN_VERIFICATION = 5,

        /// <summary>
        /// Enum NECESSARY_IMAGE_NOT_FOUND for value: 7
        /// </summary>
        NECESSARY_IMAGE_NOT_FOUND = 7,

        /// <summary>
        /// Enum PHOTO_SIDES_NOT_FOUND for value: 8
        /// </summary>
        PHOTO_SIDES_NOT_FOUND = 8,

        /// <summary>
        /// Enum INVALID_CHECKSUM for value: 10
        /// </summary>
        INVALID_CHECKSUM = 10,

        /// <summary>
        /// Enum SYNTAX_ERROR for value: 11
        /// </summary>
        SYNTAX_ERROR = 11,

        /// <summary>
        /// Enum LOGIC_ERROR for value: 12
        /// </summary>
        LOGIC_ERROR = 12,

        /// <summary>
        /// Enum SOURCES_COMPARISON_ERROR for value: 13
        /// </summary>
        SOURCES_COMPARISON_ERROR = 13,

        /// <summary>
        /// Enum FIELDS_COMPARISON_LOGIC_ERROR for value: 14
        /// </summary>
        FIELDS_COMPARISON_LOGIC_ERROR = 14,

        /// <summary>
        /// Enum INVALID_FIELD_FORMAT for value: 15
        /// </summary>
        INVALID_FIELD_FORMAT = 15,

        /// <summary>
        /// Enum TRUE_LUMINESCENCE_ERROR for value: 20
        /// </summary>
        TRUE_LUMINESCENCE_ERROR = 20,

        /// <summary>
        /// Enum FALSE_LUMINESCENCE_ERROR for value: 21
        /// </summary>
        FALSE_LUMINESCENCE_ERROR = 21,

        /// <summary>
        /// Enum FIXED_PATTERN_ERROR for value: 22
        /// </summary>
        FIXED_PATTERN_ERROR = 22,

        /// <summary>
        /// Enum LOW_CONTRAST_IN_IR_LIGHT for value: 23
        /// </summary>
        LOW_CONTRAST_IN_IR_LIGHT = 23,

        /// <summary>
        /// Enum INCORRECT_BACKGROUND_LIGHT for value: 24
        /// </summary>
        INCORRECT_BACKGROUND_LIGHT = 24,

        /// <summary>
        /// Enum BACKGROUND_COMPARISON_ERROR for value: 25
        /// </summary>
        BACKGROUND_COMPARISON_ERROR = 25,

        /// <summary>
        /// Enum INCORRECT_TEXT_COLOR for value: 26
        /// </summary>
        INCORRECT_TEXT_COLOR = 26,

        /// <summary>
        /// Enum PHOTO_FALSE_LUMINESCENCE for value: 27
        /// </summary>
        PHOTO_FALSE_LUMINESCENCE = 27,

        /// <summary>
        /// Enum TOO_MUCH_SHIFT for value: 28
        /// </summary>
        TOO_MUCH_SHIFT = 28,

        /// <summary>
        /// Enum CONTACT_CHIP_TYPE_MISMATCH for value: 29
        /// </summary>
        CONTACT_CHIP_TYPE_MISMATCH = 29,

        /// <summary>
        /// Enum FIBERS_NOT_FOUND for value: 30
        /// </summary>
        FIBERS_NOT_FOUND = 30,

        /// <summary>
        /// Enum TOO_MANY_OBJECTS for value: 31
        /// </summary>
        TOO_MANY_OBJECTS = 31,

        /// <summary>
        /// Enum SPECKS_IN_UV for value: 33
        /// </summary>
        SPECKS_IN_UV = 33,

        /// <summary>
        /// Enum TOO_LOW_RESOLUTION for value: 34
        /// </summary>
        TOO_LOW_RESOLUTION = 34,

        /// <summary>
        /// Enum INVISIBLE_ELEMENT_PRESENT for value: 40
        /// </summary>
        INVISIBLE_ELEMENT_PRESENT = 40,

        /// <summary>
        /// Enum VISIBLE_ELEMENT_ABSENT for value: 41
        /// </summary>
        VISIBLE_ELEMENT_ABSENT = 41,

        /// <summary>
        /// Enum ELEMENT_SHOULD_BE_COLORED for value: 42
        /// </summary>
        ELEMENT_SHOULD_BE_COLORED = 42,

        /// <summary>
        /// Enum ELEMENT_SHOULD_BE_GRAYSCALE for value: 43
        /// </summary>
        ELEMENT_SHOULD_BE_GRAYSCALE = 43,

        /// <summary>
        /// Enum PHOTO_WHITE_IR_DONT_MATCH for value: 44
        /// </summary>
        PHOTO_WHITE_IR_DONT_MATCH = 44,

        /// <summary>
        /// Enum UV_DULL_PAPER_MRZ for value: 50
        /// </summary>
        UV_DULL_PAPER_MRZ = 50,

        /// <summary>
        /// Enum FALSE_LUMINESCENCE_IN_MRZ for value: 51
        /// </summary>
        FALSE_LUMINESCENCE_IN_MRZ = 51,

        /// <summary>
        /// Enum UV_DULL_PAPER_PHOTO for value: 52
        /// </summary>
        UV_DULL_PAPER_PHOTO = 52,

        /// <summary>
        /// Enum UV_DULL_PAPER_BLANK for value: 53
        /// </summary>
        UV_DULL_PAPER_BLANK = 53,

        /// <summary>
        /// Enum UV_DULL_PAPER_ERROR for value: 54
        /// </summary>
        UV_DULL_PAPER_ERROR = 54,

        /// <summary>
        /// Enum FALSE_LUMINESCENCE_IN_BLANK for value: 55
        /// </summary>
        FALSE_LUMINESCENCE_IN_BLANK = 55,

        /// <summary>
        /// Enum BAD_AREA_IN_AXIAL for value: 60
        /// </summary>
        BAD_AREA_IN_AXIAL = 60,

        /// <summary>
        /// Enum FALSE_IPI_PARAMETERS for value: 65
        /// </summary>
        FALSE_IPI_PARAMETERS = 65,

        /// <summary>
        /// Enum ENCRYPTED_IPI_NOT_FOUND for value: 66
        /// </summary>
        ENCRYPTED_IPI_NOT_FOUND = 66,

        /// <summary>
        /// Enum ENCRYPTED_IPI_DATA_DONT_MATCH for value: 67
        /// </summary>
        ENCRYPTED_IPI_DATA_DONT_MATCH = 67,

        /// <summary>
        /// Enum FIELD_POS_CORRECTOR_HIGHLIGHT_IR for value: 80
        /// </summary>
        FIELD_POS_CORRECTOR_HIGHLIGHT_IR = 80,

        /// <summary>
        /// Enum FIELD_POS_CORRECTOR_GLARES_IN_PHOTO_AREA for value: 81
        /// </summary>
        FIELD_POS_CORRECTOR_GLARES_IN_PHOTO_AREA = 81,

        /// <summary>
        /// Enum FIELD_POS_CORRECTOR_PHOTO_REPLACED for value: 82
        /// </summary>
        FIELD_POS_CORRECTOR_PHOTO_REPLACED = 82,

        /// <summary>
        /// Enum FIELD_POS_CORRECTOR_LANDMARKS_CHECK_ERROR for value: 83
        /// </summary>
        FIELD_POS_CORRECTOR_LANDMARKS_CHECK_ERROR = 83,

        /// <summary>
        /// Enum FIELD_POS_CORRECTOR_FACE_PRESENCE_CHECK_ERROR for value: 84
        /// </summary>
        FIELD_POS_CORRECTOR_FACE_PRESENCE_CHECK_ERROR = 84,

        /// <summary>
        /// Enum FIELD_POS_CORRECTOR_FACE_ABSENCE_CHECK_ERROR for value: 85
        /// </summary>
        FIELD_POS_CORRECTOR_FACE_ABSENCE_CHECK_ERROR = 85,

        /// <summary>
        /// Enum FIELD_POS_CORRECTOR_INCORRECT_HEAD_POSITION for value: 86
        /// </summary>
        FIELD_POS_CORRECTOR_INCORRECT_HEAD_POSITION = 86,

        /// <summary>
        /// Enum OVI_IR_INVISIBLE for value: 90
        /// </summary>
        OVI_IR_INVISIBLE = 90,

        /// <summary>
        /// Enum OVI_INSUFFICIENT_AREA for value: 91
        /// </summary>
        OVI_INSUFFICIENT_AREA = 91,

        /// <summary>
        /// Enum OVI_COLOR_INVARIABLE for value: 92
        /// </summary>
        OVI_COLOR_INVARIABLE = 92,

        /// <summary>
        /// Enum OVI_BAD_COLOR_FRONT for value: 93
        /// </summary>
        OVI_BAD_COLOR_FRONT = 93,

        /// <summary>
        /// Enum OVI_BAD_COLOR_SIDE for value: 94
        /// </summary>
        OVI_BAD_COLOR_SIDE = 94,

        /// <summary>
        /// Enum OVI_WIDE_COLOR_SPREAD for value: 95
        /// </summary>
        OVI_WIDE_COLOR_SPREAD = 95,

        /// <summary>
        /// Enum OVI_BAD_COLOR_PERCENT for value: 96
        /// </summary>
        OVI_BAD_COLOR_PERCENT = 96,

        /// <summary>
        /// Enum HOLOGRAM_ELEMENT_ABSENT for value: 100
        /// </summary>
        HOLOGRAM_ELEMENT_ABSENT = 100,

        /// <summary>
        /// Enum HOLOGRAM_SIDE_TOP_IMAGES_ABSENT for value: 101
        /// </summary>
        HOLOGRAM_SIDE_TOP_IMAGES_ABSENT = 101,

        /// <summary>
        /// Enum HOLOGRAM_ELEMENT_PRESENT for value: 102
        /// </summary>
        HOLOGRAM_ELEMENT_PRESENT = 102,

        /// <summary>
        /// Enum HOLOGRAM_FRAMES_IS_ABSENT for value: 103
        /// </summary>
        HOLOGRAM_FRAMES_IS_ABSENT = 103,

        /// <summary>
        /// Enum HOLOGRAM_HOLO_FIELD_IS_ABSENT for value: 104
        /// </summary>
        HOLOGRAM_HOLO_FIELD_IS_ABSENT = 104,

        /// <summary>
        /// Enum PHOTO_PATTERN_INTERRUPTED for value: 110
        /// </summary>
        PHOTO_PATTERN_INTERRUPTED = 110,

        /// <summary>
        /// Enum PHOTO_PATTERN_SHIFTED for value: 111
        /// </summary>
        PHOTO_PATTERN_SHIFTED = 111,

        /// <summary>
        /// Enum PHOTO_PATTERN_DIFFERENT_COLORS for value: 112
        /// </summary>
        PHOTO_PATTERN_DIFFERENT_COLORS = 112,

        /// <summary>
        /// Enum PHOTO_PATTERN_IR_VISIBLE for value: 113
        /// </summary>
        PHOTO_PATTERN_IR_VISIBLE = 113,

        /// <summary>
        /// Enum PHOTO_PATTERN_NOT_INTERSECT for value: 114
        /// </summary>
        PHOTO_PATTERN_NOT_INTERSECT = 114,

        /// <summary>
        /// Enum PHOTO_SIZE_IS_WRONG for value: 115
        /// </summary>
        PHOTO_SIZE_IS_WRONG = 115,

        /// <summary>
        /// Enum PHOTO_PATTERN_INVALID_COLOR for value: 116
        /// </summary>
        PHOTO_PATTERN_INVALID_COLOR = 116,

        /// <summary>
        /// Enum PHOTO_PATTERN_SHIFTED_VERT for value: 117
        /// </summary>
        PHOTO_PATTERN_SHIFTED_VERT = 117,

        /// <summary>
        /// Enum PHOTO_PATTERN_PATTERN_NOT_FOUND for value: 118
        /// </summary>
        PHOTO_PATTERN_PATTERN_NOT_FOUND = 118,

        /// <summary>
        /// Enum PHOTO_PATTERN_DIFFERENT_LINES_THICKNESS for value: 119
        /// </summary>
        PHOTO_PATTERN_DIFFERENT_LINES_THICKNESS = 119,

        /// <summary>
        /// Enum PHOTO_IS_NOT_RECTANGLE for value: 120
        /// </summary>
        PHOTO_IS_NOT_RECTANGLE = 120,

        /// <summary>
        /// Enum PHOTO_CORNERS_IS_WRONG for value: 121
        /// </summary>
        PHOTO_CORNERS_IS_WRONG = 121,

        /// <summary>
        /// Enum DOCUMENT_IS_CANCELLING for value: 122
        /// </summary>
        DOCUMENT_IS_CANCELLING = 122,

        /// <summary>
        /// Enum TEXT_COLOR_SHOULD_BE_BLUE for value: 130
        /// </summary>
        TEXT_COLOR_SHOULD_BE_BLUE = 130,

        /// <summary>
        /// Enum TEXT_COLOR_SHOULD_BE_GREEN for value: 131
        /// </summary>
        TEXT_COLOR_SHOULD_BE_GREEN = 131,

        /// <summary>
        /// Enum TEXT_COLOR_SHOULD_BE_RED for value: 132
        /// </summary>
        TEXT_COLOR_SHOULD_BE_RED = 132,

        /// <summary>
        /// Enum TEXT_SHOULD_BE_BLACK for value: 133
        /// </summary>
        TEXT_SHOULD_BE_BLACK = 133,

        /// <summary>
        /// Enum BARCODE_WAS_READ_WITH_ERRORS for value: 140
        /// </summary>
        BARCODE_WAS_READ_WITH_ERRORS = 140,

        /// <summary>
        /// Enum BARCODE_DATA_FORMAT_ERROR for value: 141
        /// </summary>
        BARCODE_DATA_FORMAT_ERROR = 141,

        /// <summary>
        /// Enum BARCODE_SIZE_PARAMS_ERROR for value: 142
        /// </summary>
        BARCODE_SIZE_PARAMS_ERROR = 142,

        /// <summary>
        /// Enum NOT_ALL_BARCODES_READ for value: 143
        /// </summary>
        NOT_ALL_BARCODES_READ = 143,

        /// <summary>
        /// Enum GLARES_IN_BARCODE_AREA for value: 144
        /// </summary>
        GLARES_IN_BARCODE_AREA = 144,

        /// <summary>
        /// Enum NO_CERTIFICATE_FOR_DIGITAL_SIGNATURE_CHECK for value: 145
        /// </summary>
        NO_CERTIFICATE_FOR_DIGITAL_SIGNATURE_CHECK = 145,

        /// <summary>
        /// Enum PORTRAIT_COMPARISON_PORTRAITS_DIFFER for value: 150
        /// </summary>
        PORTRAIT_COMPARISON_PORTRAITS_DIFFER = 150,

        /// <summary>
        /// Enum PORTRAIT_COMPARISON_NO_SERVICE_REPLY for value: 151
        /// </summary>
        PORTRAIT_COMPARISON_NO_SERVICE_REPLY = 151,

        /// <summary>
        /// Enum PORTRAIT_COMPARISON_SERVICE_ERROR for value: 152
        /// </summary>
        PORTRAIT_COMPARISON_SERVICE_ERROR = 152,

        /// <summary>
        /// Enum PORTRAIT_COMPARISON_NOT_ENOUGH_IMAGES for value: 153
        /// </summary>
        PORTRAIT_COMPARISON_NOT_ENOUGH_IMAGES = 153,

        /// <summary>
        /// Enum PORTRAIT_COMPARISON_NO_LIVE_PHOTO for value: 154
        /// </summary>
        PORTRAIT_COMPARISON_NO_LIVE_PHOTO = 154,

        /// <summary>
        /// Enum PORTRAIT_COMPARISON_NO_SERVICE_LICENSE for value: 155
        /// </summary>
        PORTRAIT_COMPARISON_NO_SERVICE_LICENSE = 155,

        /// <summary>
        /// Enum PORTRAIT_COMPARISON_NO_PORTRAIT_DETECTED for value: 156
        /// </summary>
        PORTRAIT_COMPARISON_NO_PORTRAIT_DETECTED = 156,

        /// <summary>
        /// Enum MOBILE_IMAGES_UNSUITABLE_LIGHT_CONDITIONS for value: 160
        /// </summary>
        MOBILE_IMAGES_UNSUITABLE_LIGHT_CONDITIONS = 160,

        /// <summary>
        /// Enum MOBILE_IMAGES_WHITE_UV_NO_DIFFERENCE for value: 161
        /// </summary>
        MOBILE_IMAGES_WHITE_UV_NO_DIFFERENCE = 161,

        /// <summary>
        /// Enum FINGERPRINTS_COMPARISON_MISMATCH for value: 170
        /// </summary>
        FINGERPRINTS_COMPARISON_MISMATCH = 170,

        /// <summary>
        /// Enum HOLO_PHOTO_FACE_NOT_DETECTED for value: 180
        /// </summary>
        HOLO_PHOTO_FACE_NOT_DETECTED = 180,

        /// <summary>
        /// Enum HOLO_PHOTO_FACE_COMPARISON_FAILED for value: 181
        /// </summary>
        HOLO_PHOTO_FACE_COMPARISON_FAILED = 181,

        /// <summary>
        /// Enum HOLO_PHOTO_GLARE_IN_CENTER_ABSENT for value: 182
        /// </summary>
        HOLO_PHOTO_GLARE_IN_CENTER_ABSENT = 182,

        /// <summary>
        /// Enum HOLO_PHOTO_HOLO_ELEMENT_SHAPE_ERROR for value: 183
        /// </summary>
        HOLO_PHOTO_HOLO_ELEMENT_SHAPE_ERROR = 183,

        /// <summary>
        /// Enum HOLO_PHOTO_ALGORITHMS_STEPS_ERROR for value: 184
        /// </summary>
        HOLO_PHOTO_ALGORITHMS_STEPS_ERROR = 184,

        /// <summary>
        /// Enum HOLO_PHOTO_HOLO_AREAS_NOT_LOADED for value: 185
        /// </summary>
        HOLO_PHOTO_HOLO_AREAS_NOT_LOADED = 185,

        /// <summary>
        /// Enum HOLO_PHOTO_FINISHED_BY_TIMEOUT for value: 186
        /// </summary>
        HOLO_PHOTO_FINISHED_BY_TIMEOUT = 186,

        /// <summary>
        /// Enum HOLO_PHOTO_DOCUMENT_OUTSIDE_FRAME for value: 187
        /// </summary>
        HOLO_PHOTO_DOCUMENT_OUTSIDE_FRAME = 187,

        /// <summary>
        /// Enum LIVENESS_DEPTH_CHECK_FAILED for value: 190
        /// </summary>
        LIVENESS_DEPTH_CHECK_FAILED = 190,

        /// <summary>
        /// Enum MRZ_QUALITY_WRONG_SYMBOL_POSITION for value: 200
        /// </summary>
        MRZ_QUALITY_WRONG_SYMBOL_POSITION = 200,

        /// <summary>
        /// Enum MRZ_QUALITY_WRONG_BACKGROUND for value: 201
        /// </summary>
        MRZ_QUALITY_WRONG_BACKGROUND = 201,

        /// <summary>
        /// Enum MRZ_QUALITY_WRONG_MRZ_WIDTH for value: 202
        /// </summary>
        MRZ_QUALITY_WRONG_MRZ_WIDTH = 202,

        /// <summary>
        /// Enum MRZ_QUALITY_WRONG_MRZ_HEIGHT for value: 203
        /// </summary>
        MRZ_QUALITY_WRONG_MRZ_HEIGHT = 203,

        /// <summary>
        /// Enum MRZ_QUALITY_WRONG_LINE_POSITION for value: 204
        /// </summary>
        MRZ_QUALITY_WRONG_LINE_POSITION = 204,

        /// <summary>
        /// Enum MRZ_QUALITY_WRONG_FONT_TYPE for value: 205
        /// </summary>
        MRZ_QUALITY_WRONG_FONT_TYPE = 205,

        /// <summary>
        /// Enum OCR_QUALITY_TEXT_POSITION for value: 220
        /// </summary>
        OCR_QUALITY_TEXT_POSITION = 220,

        /// <summary>
        /// Enum OCR_QUALITY_INVALID_FONT for value: 221
        /// </summary>
        OCR_QUALITY_INVALID_FONT = 221,

        /// <summary>
        /// Enum OCR_QUALITY_INVALID_BACKGROUND for value: 222
        /// </summary>
        OCR_QUALITY_INVALID_BACKGROUND = 222,

        /// <summary>
        /// Enum LASINK_INVALID_LINES_FREQUENCY for value: 230
        /// </summary>
        LASINK_INVALID_LINES_FREQUENCY = 230,

        /// <summary>
        /// Enum DOC_LIVENESS_DOCUMENT_NOT_LIVE for value: 238
        /// </summary>
        DOC_LIVENESS_DOCUMENT_NOT_LIVE = 238,

        /// <summary>
        /// Enum DOC_LIVENESS_BLACK_AND_WHITE_COPY_DETECTED for value: 239
        /// </summary>
        DOC_LIVENESS_BLACK_AND_WHITE_COPY_DETECTED = 239,

        /// <summary>
        /// Enum DOC_LIVENESS_ELECTRONIC_DEVICE_DETECTED for value: 240
        /// </summary>
        DOC_LIVENESS_ELECTRONIC_DEVICE_DETECTED = 240,

        /// <summary>
        /// Enum DOC_LIVENESS_INVALID_BARCODE_BACKGROUND for value: 241
        /// </summary>
        DOC_LIVENESS_INVALID_BARCODE_BACKGROUND = 241,

        /// <summary>
        /// Enum CHD_ICAO_IDB_BASE32_ERROR for value: 243
        /// </summary>
        CHD_ICAO_IDB_BASE32_ERROR = 243,

        /// <summary>
        /// Enum CHD_ICAO_IDB_ZIPPED_ERROR for value: 244
        /// </summary>
        CHD_ICAO_IDB_ZIPPED_ERROR = 244,

        /// <summary>
        /// Enum CHD_ICAO_IDB_MESSAGE_ZONE_EMPTY for value: 245
        /// </summary>
        CHD_ICAO_IDB_MESSAGE_ZONE_EMPTY = 245,

        /// <summary>
        /// Enum CHD_ICAO_IDB_SIGNATURE_MUST_BE_PRESENT for value: 246
        /// </summary>
        CHD_ICAO_IDB_SIGNATURE_MUST_BE_PRESENT = 246,

        /// <summary>
        /// Enum CHD_ICAO_IDB_SIGNATURE_MUST_NOT_BE_PRESENT for value: 247
        /// </summary>
        CHD_ICAO_IDB_SIGNATURE_MUST_NOT_BE_PRESENT = 247,

        /// <summary>
        /// Enum CHD_ICAO_IDB_CERTIFICATE_MUST_NOT_BE_PRESENT for value: 248
        /// </summary>
        CHD_ICAO_IDB_CERTIFICATE_MUST_NOT_BE_PRESENT = 248,

        /// <summary>
        /// Enum CHD_INCORRECT_OBJECT_COLOR for value: 250
        /// </summary>
        CHD_INCORRECT_OBJECT_COLOR = 250
    }

}

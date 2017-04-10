/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 08/04/2017
 * Hora: 16:47
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Diagnostics;
using System.Configuration;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace CustomFormat
{
	/// <summary>
	/// Description of YamlInputFormatter.
	/// </summary>
	public class YamlInputFormatter : TextInputFormatter
	{
		private readonly Deserializer _deserializer;

		public YamlInputFormatter(Deserializer deserializer)
		{
			_deserializer = deserializer;

			SupportedEncodings.Add(Encoding.UTF8);
			SupportedEncodings.Add(Encoding.Unicode);
			SupportedMediaTypes.Add(MediaTypeHeaderValues.ApplicationYaml);
			SupportedMediaTypes.Add(MediaTypeHeaderValues.TextYaml);
		}

		public override Task<InputFormatterResult> ReadRequestBodyAsync(InputFormatterContext context, Encoding encoding)
		{
			if (context == null) {
				throw new ArgumentNullException(nameof(context));
			}

			if (encoding == null) {
				throw new ArgumentNullException(nameof(encoding));
			}

			var request = context.HttpContext.Request;

			using (var streamReader = context.ReaderFactory(request.Body, encoding)) {
				var type = context.ModelType;

				try {
					var model = _deserializer.Deserialize(streamReader, type);
					return InputFormatterResult.SuccessAsync(model);
				} catch (Exception) {
					return InputFormatterResult.FailureAsync();
				}
			}
		}
	}
	/// <summary>
	/// Description of YamlOutputFormatter.
	/// </summary>
	public class YamlOutputFormatter : TextOutputFormatter
	{
		private readonly Serializer _serializer;

		public YamlOutputFormatter(Serializer serializer)
		{
			_serializer = serializer;

			SupportedEncodings.Add(Encoding.UTF8);
			SupportedEncodings.Add(Encoding.Unicode);
			SupportedMediaTypes.Add(MediaTypeHeaderValues.ApplicationYaml);
			SupportedMediaTypes.Add(MediaTypeHeaderValues.TextYaml);
		}

		public override async Task WriteResponseBodyAsync(OutputFormatterWriteContext context, Encoding selectedEncoding)
		{
			if (context == null) {
				throw new ArgumentNullException(nameof(context));
			}

			if (selectedEncoding == null) {
				throw new ArgumentNullException(nameof(selectedEncoding));
			}

			var response = context.HttpContext.Response;
			using (var writer = context.WriterFactory(response.Body, selectedEncoding)) {
				WriteObject(writer, context.Object);

				await writer.FlushAsync();
			}
		}

		private void WriteObject(TextWriter writer, object value)
		{
			if (writer == null) {
				throw new ArgumentNullException(nameof(writer));
			}

			_serializer.Serialize(writer, value);
		}
	}
	
	internal static class MediaTypeHeaderValues
	{
		public static readonly MediaTypeHeaderValue ApplicationYaml
        = MediaTypeHeaderValue.Parse("application/x-yaml").CopyAsReadOnly();

		public static readonly MediaTypeHeaderValue TextYaml
        = MediaTypeHeaderValue.Parse("text/yaml").CopyAsReadOnly();
	}
}

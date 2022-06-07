using CsvHelper;
using CsvHelper.Configuration;
using GloboTicket.TicketManagement.Application.Contracts.Infrastructure;
using GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventsExport;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace GloboTicket.TicketManagement.Infrastructure.FileExport
{
    public class CsvExporter : ICsvExporter
    {
        public byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                NewLine = Environment.NewLine,
            };

            using var memoryStream = new MemoryStream();
            using (var stramWriter = new StreamWriter(memoryStream))
            {
                using var csvWriter = new CsvWriter(stramWriter, config);
                csvWriter.WriteRecord(eventExportDtos);
            }

            return memoryStream.ToArray();
        }
    }
}

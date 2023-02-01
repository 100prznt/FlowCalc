using FlowCalc.PoolSystem;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCalc.BatchProcessing
{
    public class BatchProcessor
    {
        //Innendurchmesser;Rauheit;Länge;Volumenstrom;Fließgeschwindigkeit;Druckabfall

        const char COL_SEPERATOR = ';';

        const string DIAMETER_COL_HEADER = "Innendurchmesser";
        const string ROUGHNESS_COL_HEADER = "Rauheit";
        const string LENGTH_COL_HEADER = "Länge";
        const string FLOWRATE_COL_HEADER = "Volumenstrom";
        const string VELOCITY_COL_HEADER = "Fließgeschwindigkeit";
        const string PRESSUREDROP_COL_HEADER = "Druckabfall";

        /// <summary>
        /// Daten für eine Stapelverarbeitung sind vorhanden
        /// </summary>
        public bool HasData { get; set; }

        Dictionary<string, int> m_ColDefinition;
        List<Pipe> m_Pipes;
        string m_Header;

        public bool LoadCsv(string path)
        {
            try
            {
                if (m_Pipes == null)
                    m_Pipes = new List<Pipe>();

                using (var sr = new StreamReader(path))
                {
                    ParseHeader(sr.ReadLine());

                    while (!sr.EndOfStream)
                        m_Pipes.Add(ParseRow(sr.ReadLine()));
                }

                HasData = m_Pipes.Count > 0;
            }
            catch (Exception)
            {
                m_Pipes = null;
                HasData = false;
            }
            
            return HasData;
        }

        public void SaveCsv(string path)
        {
            using (var sw = new StreamWriter(path))
            {
                sw.WriteLine(m_Header);

                foreach (var pipe in m_Pipes)
                    sw.WriteLine(ToCsvRow(pipe));
            }
        }

        private void ParseHeader(string header)
        {
            m_Header = header;
            var colHeaders = header.Split(new char[] { COL_SEPERATOR }, StringSplitOptions.None);
            var cols = new Dictionary<string, int>();
            for (var i = 0; i < colHeaders.Length; i++)
                cols.Add(colHeaders[i],i);

            m_ColDefinition = cols;
        }

        private Pipe ParseRow(string row)
        {
            var cols = row.Split(new char[] { COL_SEPERATOR }, StringSplitOptions.None);
            var pipe = new Pipe();

            if (m_ColDefinition.TryGetValue(DIAMETER_COL_HEADER, out var i))
                pipe.Diameter = double.Parse(cols[i]);

            if (m_ColDefinition.TryGetValue(ROUGHNESS_COL_HEADER, out i))
                pipe.Roughness = double.Parse(cols[i]);

            if (m_ColDefinition.TryGetValue(LENGTH_COL_HEADER, out i))
                pipe.Length = double.Parse(cols[i]);

            if (m_ColDefinition.TryGetValue(FLOWRATE_COL_HEADER, out i))
                pipe.FlowRate = double.Parse(cols[i]);

            return pipe;
        }

        private string ToCsvRow(Pipe pipe)
        {
            var pipeData = new Dictionary<int, double>();

            if (m_ColDefinition.TryGetValue(DIAMETER_COL_HEADER, out var i))
                pipeData.Add(i, pipe.Diameter);

            if (m_ColDefinition.TryGetValue(ROUGHNESS_COL_HEADER, out i))
                pipeData.Add(i, pipe.Roughness);

            if (m_ColDefinition.TryGetValue(LENGTH_COL_HEADER, out i))
                pipeData.Add(i, pipe.Length);

            if (m_ColDefinition.TryGetValue(FLOWRATE_COL_HEADER, out i))
                pipeData.Add(i, pipe.FlowRate);

            if (m_ColDefinition.TryGetValue(VELOCITY_COL_HEADER, out i))
                pipeData.Add(i, pipe.CalcFlowVelocity());

            if (m_ColDefinition.TryGetValue(PRESSUREDROP_COL_HEADER, out i))
                pipeData.Add(i, pipe.CalcPressureDrop(Medium.Water25));


            var row = new StringBuilder();

            for (i = 0; i <= pipeData.Max(x => x.Key); i++)
            {
                if (pipeData.TryGetValue(i, out var value))
                    row.Append(value);
                row.Append(COL_SEPERATOR);
            }

            return row.ToString();
        }
    }
}

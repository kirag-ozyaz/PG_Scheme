using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;

/// <summary>
///  #region Контроль удаленной службы
/// </summary>
public class ControlServices
{
    private const int _timeInterval = 1;
    private string _serviceName = "EIS SchemeService";
    private string _machineName = "ulges-app";

    //string MachineName = "ulges-app";
    //string ServiceName = "EIS SchemeService";

    public string ServiceName {
        get { return _serviceName; }
        set { _serviceName = value; }
    }
    public string MachineName
    {
        get { return _machineName; }
        set { _machineName = value; }
    }

    //public ControlServices()
    //{


    //}

    /// <summary>
    /// Проверка статуса службы
    /// </summary>
    public ServiceStatus Status()
    {
        string statusName = "";
        ServiceStatus serviceStatus;
        try
        {
            ServiceController service = new ServiceController(_serviceName, _machineName);
            switch (service.Status)
            {
                case ServiceControllerStatus.Running:
                    statusName = "Служба запущена";
                    break;
                case ServiceControllerStatus.Stopped:
                    statusName = "Служба остановлена";
                    break;
                case ServiceControllerStatus.Paused:
                    statusName = "Служба приостановлена";
                    break;
                case ServiceControllerStatus.StartPending:
                    statusName = "Служба запускается...";
                    break;
                case ServiceControllerStatus.StopPending:
                    statusName = "Служба останавливается...";
                    break;
                case ServiceControllerStatus.PausePending:
                    statusName = "Ожидается приостановка службы...";
                    break;
                case ServiceControllerStatus.ContinuePending:
                    statusName = "Ожидается возобновление работы службы...";
                    break;

                default:
                    statusName = "Неизвестное состояние";
                    break;
            }

            serviceStatus = new ServiceStatus(statusName, service.Status);
        }
        catch
        {
            return null;
        }
        return serviceStatus;

    }
    /// <summary>
    /// Запуск службы
    /// </summary>
    /// <param name="machineName"></param>
    /// <param name="serviceName"></param>
    public void Start()
    {
        ServiceController service = new ServiceController(_serviceName, _machineName);
        // Проверяем не запущена ли служба
        if (service.Status != ServiceControllerStatus.Running)
        {
            // Запускаем службу
            service.Start();
            // В течении минуты ждём статус от службы
            service.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromMinutes(_timeInterval));
            //MessageBox.Show("Служба была успешно запущена!");
        }
        else
        {
            //MessageBox.Show("Служба уже запущена!");
        }
    }

    /// <summary>
    /// Останавливаем службу
    /// </summary>
    /// <param name="serviceName"></param>
    public void Stop()
    {
        ServiceController service = new ServiceController(_serviceName, _machineName);
        // Если служба не остановлена
        if (service.Status != ServiceControllerStatus.Stopped)
        {
            // Останавливаем службу
            service.Stop();
            service.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromMinutes(_timeInterval));
            //MessageBox.Show("Служба была успешно остановлена!");
        }
        else
        {
            //MessageBox.Show("Служба уже остановлена!");
        }
    }

    /// <summary>
    /// Перезапуск службы
    /// </summary>
    /// <param name="serviceName"></param>
    public void Restart()
    {
        ServiceController service = new ServiceController(_serviceName, _machineName);
        TimeSpan timeout = TimeSpan.FromMinutes(1);
        if (service.Status != ServiceControllerStatus.Stopped)
        {
            //Console.WriteLine("Перезапуск службы. Останавливаем службу...");
            // Останавливаем службу
            service.Stop();
            service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
            //Console.WriteLine("Служба была успешно остановлена!");
        }
        if (service.Status != ServiceControllerStatus.Running)
        {
            //Console.WriteLine("Перезапуск службы. Запускаем службу...");
            // Запускаем службу
            service.Start();
            service.WaitForStatus(ServiceControllerStatus.Running, timeout);
            //Console.WriteLine("Служба была успешно запущена!");
        }
    }


}

public class ServiceStatus
{
    internal ServiceStatus(string name, ServiceControllerStatus id)
    {
        this.Name = name;
        this.Id = id;
    }

    internal string Name;
    internal ServiceControllerStatus Id;
}
namespace MauiApp1;

public partial class MainPage : ContentPage
{
    private Task<double> _calcSinTask;
    private CancellationTokenSource _cts;
    CancellationToken token;
    private double _step = 0.000000002;

    private double CalculateSin()
    {
        MainThread.BeginInvokeOnMainThread(() =>
        {
            answer.Text = "Вычисление";
        });
        double border = 0;
        double sin = 0;
        int percent = 0;
        int prevPercent = -1;
        while (border <= 1)
        {
            if (token.IsCancellationRequested)
            {
                MainThread.BeginInvokeOnMainThread(() =>
                {
                    answer.Text = "АААААААААА";
                });
                return sin;
            }
            sin += Math.Sin(border) * _step;
            border += _step;
            percent = (int)(border / 1.0 * 100);

            if (percent != prevPercent)
            {
                prevPercent = percent;
                MainThread.BeginInvokeOnMainThread(() =>
                {
                    ProgressBar.Progress = percent / 100.0;
                    answer.Text = percent + "%";
                });
            }
        }
        return sin;
    }
  
    public MainPage()
	{
        InitializeComponent();
	}

	private  async void StartBtnClicked(object sender, EventArgs e)
	{
        if (_calcSinTask?.Status != TaskStatus.Running)
        {
            _cts = new CancellationTokenSource();     
            token = _cts.Token;
            _calcSinTask = new Task<double>((CalculateSin),token);
            _calcSinTask.Start();

            double sin = await _calcSinTask;
            answer.Text = "sin value = " + sin.ToString();
            _cts.Dispose();
            _cts = null;
        }
        
       
    }

	private void CancelBtnClicked(object sender, EventArgs e)
	{
        if (_calcSinTask?.Status == TaskStatus.Running)
        {
            _cts.Cancel();
            token = _cts.Token;
        }
    }
}


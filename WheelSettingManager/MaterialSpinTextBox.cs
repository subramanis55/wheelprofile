#region

using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Reflection.Emit;
using System.Windows.Forms;

#endregion

namespace MaterialLibrary
{
	[ToolboxItem(true)]
	public partial class MTextBox : MaterialControl
	{
	
		//private int count, incTimerValue;

	
		//private bool IsMouseDown, forceCapture, selectable;
		
		//private string suffix, decToolTipText, incToolTipText;

	
		

		//public MaterialSpinTextBox()
		//{
		//	InitializeComponent();
		//}

		///// <summary>
		/////     Gets or sets the buttons font.
		///// </summary>
		///// <value>
		/////     The buttons font.
		///// </value>
		//[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		//[DefaultValue(typeof(Font), "Calibri, 15pt, style=Bold")]
		//public Font ValueFont
		//{
		//	get => IncLbl.Font;
		//	set
		//	{
		//		base.Font = value;
		//		IncLbl.Font = value;
		//	}
		//}


		//[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		//[DefaultValue(true)]
		//public bool ClearLabelOnEdit { get; set; } = true;

		//[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		//[DefaultValue(false)]
		//public bool DrawLabelBorder
		//{
		//	get => IncLbl.DrawBorder;
		//	set => IncLbl.DrawBorder = value;
		//}

	

	
	
		//[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		//[DefaultValue(null)]
		//public string Suffix
		//{
		//	get => suffix;
		//	set
		//	{
		//		suffix = value;
		//		IncLbl.Text = Value + suffix;
		//	}
		//}

		//\

		///// <summary>
		/////     Gets or sets the value.
		///// </summary>
		///// <value>
		/////     The value.
		///// </value>
		//[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		//[DefaultValue(0d)]
		//public string Value
		//{
		//	get => IncLbl.Text;
		//	set
		//	{
				
		//		IncLbl.Text = value;
		//		ValueChanged?.Invoke(this, EventArgs.Empty);
		//	}
		//}

		///// <summary>
		/////     Gets or sets a value indicating whether [force capture].
		///// </summary>
		///// <value>
		/////     <c>true</c> if [force capture]; otherwise, <c>false</c>.
		///// </value>
		//[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		//[DefaultValue(false)]
		//protected bool ForceCapture
		//{
		//	get => forceCapture & Capture;
		//	set => Capture = forceCapture = value;
		//}

	
     


       
		//public event EventHandler ValueChanged;

	

		//public override void MaterialDispose()
		//{
		//	IncLbl.KeyPress -= OnKeyPress;
		//	MaterialResource.InvertColorChanged -= OnInvertColorChanged;
		//	base.MaterialDispose();
		//}

		///// <inheritdoc />
		///// <summary>
		/////     Raises the <see cref="E:System.Windows.Forms.Control.MouseCaptureChanged" /> event.
		///// </summary>
		///// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
		//protected override void OnMouseCaptureChanged(EventArgs e)
		//{
		//	base.OnMouseCaptureChanged(e);
		//	if (forceCapture && Capture != true) Capture = true;
		//}

		///// <inheritdoc />
		///// <summary>
		/////     Raises the <see cref="E:System.Windows.Forms.Control.KeyPress" /> event.
		///// </summary>
		///// <param name="e">A <see cref="T:System.Windows.Forms.KeyPressEventArgs" /> that contains the event data.</param>
		//protected override void OnKeyPress(KeyPressEventArgs e)
		//{
		//	base.OnKeyPress(e);
		
  //          // Handle Backspace key
  //          if (e.KeyCode == Keys.Back)
  //          {
  //              if (label.Text.Length > 0)
  //              {
  //                  // Remove the last character from the label
  //                  label.Text = label.Text.Substring(0, label.Text.Length - 1);
  //              }
  //              e.SuppressKeyPress = true; // Prevents the backspace key from affecting the TextBox
  //          }
  //          // Handle Space key
  //          else if (e.KeyCode == Keys.Space)
  //          {
  //              label.Text += " ";
  //              e.SuppressKeyPress = true; // Prevents the space key from adding a space to the TextBox
  //          }
  //          // Handle Tab key
  //          else if (e.KeyCode == Keys.Tab)
  //          {
  //              label.Text += "    "; // Adds four spaces for a tab-like effect
  //              e.SuppressKeyPress = true; // Prevents the tab key from moving focus to the next control
  //          }
  //          // Handle normal characters via KeyPress event automatically
  //          else if (!e.Shift && e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z)
  //          {
  //              // Appending lowercase letters to the label
  //              label.Text += e.KeyCode.ToString().ToLower();
  //          }
  //          else if (e.Shift && e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z)
  //          {
  //              // Appending uppercase letters to the label
  //              label.Text += e.KeyCode.ToString();
  //          }
  //      }

		///// <inheritdoc />
		///// <summary>
		/////     Raises the <see cref="E:System.Windows.Forms.Control.LostFocus" /> event.
		///// </summary>
		///// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
		//protected override void OnLostFocus(EventArgs e)
		//{
		//	base.OnLostFocus(e);
		//	if (forceCapture) return;
		//	var val = currentValue;
		//	try
		//	{
		//		var text = IncLbl.Text;
		//		if (!string.IsNullOrEmpty(Suffix) && text.Contains(Suffix))
		//			text = text.Remove(IncLbl.Text.Length - Suffix.Length, Suffix.Length);
		//		if (text != null && double.TryParse(text.Trim(), out var converted)) val = converted;
		//	}
		//	catch
		//	{
		//		//ignored
		//	}

		//	Value = val;
		//	IncLbl.MaterialResource.InvertColorPalette = MaterialResource.InvertColorPalette;
		//}

		///// <inheritdoc />
		///// <summary>
		/////     Raises the <see cref="E:System.Windows.Forms.Control.MouseDown" /> event.
		///// </summary>
		///// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
		//protected override void OnMouseDown(MouseEventArgs e)
		//{
		//	base.OnMouseDown(e);
		//	if (!Bounds.Contains(e.Location))
		//	{
		//		forceCapture = false;
		//		OnLostFocus(EventArgs.Empty);
		//	}
		//}

		//protected override void OnLoad(EventArgs e)
		//{
		//	base.OnLoad(e);
		//	MaterialResource.InvertColorChanged -= OnInvertColorChanged;
		//	MaterialResource.InvertColorChanged += OnInvertColorChanged;
		//	OnInvertColorChanged(this, e);
		//}

		//private void ArrangeButtons()
		//{
		//	if (useUpDownButtons)
		//	{
		//		IncrementBtn.Dock = DockStyle.Top;
		//		DecrementBtn.Dock = DockStyle.Bottom;
		//	}
		//	else
		//	{
		//		IncrementBtn.Dock = DockStyle.Right;
		//		DecrementBtn.Dock = DockStyle.Left;
		//	}

		//	ResizeButtons();
		//}

		//private void ResizeButtons()
		//{
		//	var maxSize =
		//		Convert.ToInt32((useUpDownButtons ? ButtonsContainerPanel.Height : ButtonsContainerPanel.Width) / 100f *
		//		                maxButtonPercent);
		//	var size = !useButtonPercent
		//		? buttonSize > maxSize ? maxSize : buttonSize
		//		: Convert.ToInt32((useUpDownButtons ? ButtonsContainerPanel.Height : ButtonsContainerPanel.Width) /
		//			100f * buttonPercent);
		//	IncrementBtn.Size = DecrementBtn.Size = new Size(size, size);
		//}

		///// <summary>
		/////     Increments the value.
		///// </summary>
		//private void IncrementValue()
		//{
		//	if (InvertButtonState)
		//	{
		//		if (currentValue > minimum) Value = currentValue - Incrementor;
		//		else StopTimers();
		//	}
		//	else
		//	{
		//		if (currentValue < maximum) Value = currentValue + Incrementor;
		//		else StopTimers();
		//	}
		//}

		///// <summary>
		/////     Decrements the value.
		///// </summary>
		//private void DecrementValue()
		//{
		//	if (InvertButtonState)
		//	{
		//		if (currentValue < maximum) Value = currentValue + Incrementor;
		//		else StopTimers();
		//	}
		//	else
		//	{
		//		if (currentValue > minimum) Value = currentValue - Incrementor;
		//		else StopTimers();
		//	}
		//}

		//private void OnInvertColorChanged(object sender, EventArgs eventArgs)
		//{
		//	IncLbl.MaterialResource.InvertColorPalette = MaterialResource.InvertColorPalette;
		//	DecrementBtn.MaterialResource.InvertColorPalette =
		//		IncrementBtn.MaterialResource.InvertColorPalette = !MaterialResource.InvertColorPalette;
		//}

		///// <summary>
		/////     Called when label mouse down.
		///// </summary>
		///// <param name="sender">The sender.</param>
		///// <param name="e">The <see cref="MouseEventArgs" /> instance containing the event data.</param>
		//private void OnLabelMouseDown(object sender, MouseEventArgs e)
		//{
		//	if (forceCapture) return;
		//	lastPoint = e.Location;
		//	count = 0;
		//	IsMouseDown = true;
		//}

		///// <summary>
		/////     Called when label mouse move.
		///// </summary>
		///// <param name="sender">The sender.</param>
		///// <param name="e">The <see cref="MouseEventArgs" /> instance containing the event data.</param>
		//private void OnLabelMouseMove(object sender, MouseEventArgs e)
		//{
		//	if (e.Button != MouseButtons.Left || !IsMouseDown) return;
		//	if (count > 1)
		//	{
		//		if (useUpDownButtons)
		//		{
		//			if (e.Y < lastPoint.Y)
		//			{
		//				if (InvertButtonState) DoDecrement();
		//				else DoIncrement();
		//			}
		//			else if (e.Y > lastPoint.Y)
		//			{
		//				if (InvertButtonState) DoIncrement();
		//				else DoDecrement();
		//			}
		//		}
		//		else
		//		{
		//			if (e.X < lastPoint.X)
		//			{
		//				if (InvertButtonState) DoIncrement();
		//				else DoDecrement();
		//			}
		//			else if (e.X > lastPoint.X)
		//			{
		//				if (InvertButtonState) DoDecrement();
		//				else DoIncrement();
		//			}
		//		}

		//		count = 0;
		//	}

		//	lastPoint = e.Location;
		//	count++;
		//}

		///// <summary>
		/////     Called when label mouse up.
		///// </summary>
		///// <param name="sender">The sender.</param>
		///// <param name="e">The <see cref="MouseEventArgs" /> instance containing the event data.</param>
		//private void OnLabelMouseUp(object sender, MouseEventArgs e)
		//{
		//	count = 0;
		//	IsMouseDown = false;
		//}

		///// <summary>
		/////     Called when [decrement button clicked].
		///// </summary>
		///// <param name="sender">The sender.</param>
		///// <param name="e">The <see cref="MouseEventArgs" /> instance containing the event data.</param>
		//private void OnDecrementButtonClicked(object sender, MouseEventArgs e)
		//{
		//	StopTimers();
		//}

		///// <summary>
		/////     Called when [increment button clicked].
		///// </summary>
		///// <param name="sender">The sender.</param>
		///// <param name="e">The <see cref="MouseEventArgs" /> instance containing the event data.</param>
		//private void OnIncrementButtonClicked(object sender, MouseEventArgs e)
		//{
		//	StopTimers();
		//}

		///// <summary>
		/////     Called when [increment tick].
		///// </summary>
		///// <param name="sender">The sender.</param>
		///// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		//private void OnIncrementTick(object sender, EventArgs e)
		//{
		//	if (MouseButtons != MouseButtons.Left) return;
		//	switch (incTimerValue)
		//	{
		//		case 1:
		//			IncrementValue();
		//			break;
		//		case -1:
		//			DecrementValue();
		//			break;
		//		default:
		//			StopTimers();
		//			break;
		//	}
		//}

		//private void OnButtonPanelResized(object sender, EventArgs e)
		//{
		//	ResizeButtons();
		//}

		///// <summary>
		/////     Called when [increment start tick].
		///// </summary>
		///// <param name="sender">The sender.</param>
		///// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		//private void OnIncrementStartTick(object sender, EventArgs e)
		//{
		//	IncrementTimer.Start();
		//	IncStartTimer.Interval = 1000;
		//	if (IncrementTimer.Interval > 100) IncrementTimer.Interval -= 100;
		//}

		///// <summary>
		/////     Called when [decrement mouse down].
		///// </summary>
		///// <param name="sender">The sender.</param>
		///// <param name="e">The <see cref="MouseEventArgs" /> instance containing the event data.</param>
		//private void OnDecrementMouseDown(object sender, MouseEventArgs e)
		//{
		//	DecrementValue();
		//	incTimerValue = -1;
		//	IncStartTimer.Start();
		//}

		///// <summary>
		/////     Called when [increment mouse down].
		///// </summary>
		///// <param name="sender">The sender.</param>
		///// <param name="e">The <see cref="MouseEventArgs" /> instance containing the event data.</param>
		//private void OnIncrementMouseDown(object sender, MouseEventArgs e)
		//{
		//	IncrementValue();
		//	incTimerValue = 1;
		//	IncStartTimer.Start();
		//}

		///// <summary>
		/////     Stops the timers.
		///// </summary>
		//private void StopTimers()
		//{
		//	IncStartTimer.Interval = 500;
		//	IncrementTimer.Interval = 350;
		//	incTimerValue = 0;
		//	IncStartTimer.Stop();
		//	IncrementTimer.Stop();
		//}

		///// <summary>
		/////     Called when [key press].
		///// </summary>
		///// <param name="sender">The sender.</param>
		///// <param name="e">The <see cref="KeyPressEventArgs" /> instance containing the event data.</param>
		//private void OnKeyPress(object sender, KeyPressEventArgs e)
		//{
		//	if (forceCapture) OnKeyPress(e);
		//}

		///// <summary>
		/////     Called when [double click].
		///// </summary>
		///// <param name="sender">The sender.</param>
		///// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		//private void OnDoubleClick(object sender, EventArgs e)
		//{
		//	forceCapture = true;
		//	Capture = true;
		//	if (ClearLabelOnEdit) IncLbl.Text = suffix;
		//	IncLbl.MaterialResource.InvertColorPalette = !MaterialResource.InvertColorPalette;
		//	Focus();
		//}
	}
}
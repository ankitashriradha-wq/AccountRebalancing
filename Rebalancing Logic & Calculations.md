<?xml version="1.0" encoding="UTF-8"?>
<div xmlns:ac="http://atlassian.com/content" xmlns:ri="http://atlassian.com/resource/identifier">
  <h1>Rebalancing Logic &amp; Calculations</h1>

  <ac:structured-macro ac:name="info">
    <ac:parameter ac:name="title">Summary</ac:parameter>
    <ac:rich-text-body>
      <p>This page explains how to compute share buys/sells to rebalance a portfolio to target percentages. It includes formulas, assumptions, rounding rules, and a worked example for five securities.</p>
    </ac:rich-text-body>
  </ac:structured-macro>

  <ac:structured-macro ac:name="panel">
    <ac:parameter ac:name="title">Purpose</ac:parameter>
    <ac:rich-text-body>
      <p>To rebalance each security so its portfolio weight equals its target percentage.</p>
    </ac:rich-text-body>
  </ac:structured-macro>

  <h2>Assumptions</h2>
  <ul>
    <li>Total portfolio value used in examples: <strong>100,000</strong> (the original file contained a mix of 10,000 and 100,000 — numeric results imply 100,000).</li>
    <li>Difference is computed as: <code>Target Value − Current Value</code>.</li>
  </ul>

  <h2>Key formulas</h2>
  <ul>
    <li><strong>Target Value</strong> = (Target % / 100) × Total Portfolio Value</li>
    <li><strong>Current Value</strong> = (Current % / 100) × Total Portfolio Value</li>
    <li><strong>Difference</strong> = Target Value − Current Value</li>
    <li><strong>Shares (raw)</strong> = Difference / Unit Price</li>
  </ul>

  <ac:structured-macro ac:name="panel">
    <ac:parameter ac:name="title">Sign convention and rounding</ac:parameter>
    <ac:rich-text-body>
      <ul>
        <li>If Difference &gt; 0 → <strong>Buy</strong> (round shares up).</li>
        <li>If Difference &lt; 0 → <strong>Sell</strong> (round shares down).</li>
        <li>If Difference = 0 → <strong>None</strong>.</li>
      </ul>
    </ac:rich-text-body>
  </ac:structured-macro>

  <h2>Worked example (Test Scenarios)</h2>
  <table>
    <thead>
      <tr>
        <th>Security</th>
        <th>Target %</th>
        <th>Current %</th>
        <th>Target Value</th>
        <th>Current Value</th>
        <th>Difference</th>
        <th>Price</th>
        <th>Raw Shares</th>
        <th>Rounded Shares</th>
        <th>Action</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td>IBM</td>
        <td>20%</td>
        <td>10%</td>
        <td>20,000</td>
        <td>10,000</td>
        <td>+10,000</td>
        <td>150</td>
        <td>66.67</td>
        <td>67</td>
        <td>Buy</td>
      </tr>
      <tr>
        <td>MSFT</td>
        <td>20%</td>
        <td>20%</td>
        <td>20,000</td>
        <td>20,000</td>
        <td>0</td>
        <td>—</td>
        <td>0</td>
        <td>0</td>
        <td>None</td>
      </tr>
      <tr>
        <td>ORCL</td>
        <td>20%</td>
        <td>30%</td>
        <td>20,000</td>
        <td>30,000</td>
        <td>−10,000</td>
        <td>220</td>
        <td>−45.45</td>
        <td>−45</td>
        <td>Sell</td>
      </tr>
      <tr>
        <td>AAPL</td>
        <td>20%</td>
        <td>20%</td>
        <td>20,000</td>
        <td>20,000</td>
        <td>0</td>
        <td>—</td>
        <td>0</td>
        <td>0</td>
        <td>None</td>
      </tr>
      <tr>
        <td>HD</td>
        <td>20%</td>
        <td>20%</td>
        <td>20,000</td>
        <td>20,000</td>
        <td>0</td>
        <td>—</td>
        <td>0</td>
        <td>0</td>
        <td>None</td>
      </tr>
    </tbody>
  </table>

  <h2>Final concise output — Shares to Buy/Sell</h2>
  <table>
    <thead>
      <tr><th>Security</th><th>Buy/Sell</th><th>Shares</th></tr>
    </thead>
    <tbody>
      <tr><td>IBM</td><td>Buy</td><td>67</td></tr>
      <tr><td>MSFT</td><td>None</td><td>0</td></tr>
      <tr><td>ORCL</td><td>Sell</td><td>45</td></tr>
      <tr><td>AAPL</td><td>None</td><td>0</td></tr>
      <tr><td>HD</td><td>None</td><td>0</td></tr>
    </tbody>
  </table>

  <ac:structured-macro ac:name="decision">
    <ac:parameter ac:name="decider">Rebalancing Policy</ac:parameter>
    <ac:rich-text-body>
      <p>Rounding rule: buys round up, sells round down. Confirm whether fractional shares are allowed.</p>
    </ac:rich-text-body>
  </ac:structured-macro>

  <h2>Notes &amp; tips</h2>
  <ul>
    <li>Verify the Total Portfolio Value before running calculations — examples assume 100,000.</li>
    <li>Decide whether fractional shares are allowed in your brokerage; if allowed you can use raw shares instead of rounding.</li>
    <li>For large portfolios, consider rebalancing in cash-amount buckets first, then convert to shares to reduce rounding effects.</li>
  </ul>
</div>

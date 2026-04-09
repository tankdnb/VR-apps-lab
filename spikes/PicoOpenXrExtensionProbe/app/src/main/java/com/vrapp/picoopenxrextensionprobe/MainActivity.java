package com.vrapp.picoopenxrextensionprobe;

import android.app.Activity;
import android.graphics.Typeface;
import android.os.Bundle;
import android.os.Handler;
import android.os.Looper;
import android.util.TypedValue;
import android.view.Gravity;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.LinearLayout;
import android.widget.ScrollView;
import android.widget.TextView;

import java.io.File;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

public final class MainActivity extends Activity {
    static {
        try {
            System.loadLibrary("openxr_loader");
        } catch (UnsatisfiedLinkError ignored) {
            // The native probe reports whether the official loader was packaged and reachable.
        }
        System.loadLibrary("pico_openxr_extension_probe");
    }

    private final ExecutorService executor = Executors.newSingleThreadExecutor();
    private final Handler mainHandler = new Handler(Looper.getMainLooper());

    private TextView statusView;
    private TextView reportView;
    private Button rerunButton;

    private native String runProbeNative(String internalDataPath, String externalDataPath);

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(createContent());
        runProbe();
    }

    @Override
    protected void onDestroy() {
        executor.shutdownNow();
        super.onDestroy();
    }

    private LinearLayout createContent() {
        final int padding = dp(20);

        LinearLayout root = new LinearLayout(this);
        root.setOrientation(LinearLayout.VERTICAL);
        root.setPadding(padding, padding, padding, padding);
        root.setLayoutParams(new ViewGroup.LayoutParams(
            ViewGroup.LayoutParams.MATCH_PARENT,
            ViewGroup.LayoutParams.MATCH_PARENT));

        TextView titleView = new TextView(this);
        titleView.setText(getString(R.string.app_name));
        titleView.setTextSize(TypedValue.COMPLEX_UNIT_SP, 24);
        titleView.setTypeface(Typeface.DEFAULT_BOLD);
        titleView.setPadding(0, 0, 0, dp(12));
        root.addView(titleView);

        statusView = new TextView(this);
        statusView.setText(R.string.status_starting);
        statusView.setTextSize(TypedValue.COMPLEX_UNIT_SP, 18);
        statusView.setPadding(0, 0, 0, dp(12));
        root.addView(statusView);

        rerunButton = new Button(this);
        rerunButton.setText(R.string.run_again);
        rerunButton.setAllCaps(false);
        rerunButton.setOnClickListener(view -> runProbe());
        LinearLayout.LayoutParams buttonParams = new LinearLayout.LayoutParams(
            ViewGroup.LayoutParams.WRAP_CONTENT,
            ViewGroup.LayoutParams.WRAP_CONTENT);
        buttonParams.gravity = Gravity.START;
        buttonParams.bottomMargin = dp(12);
        root.addView(rerunButton, buttonParams);

        ScrollView scrollView = new ScrollView(this);
        LinearLayout.LayoutParams scrollParams = new LinearLayout.LayoutParams(
            ViewGroup.LayoutParams.MATCH_PARENT,
            0);
        scrollParams.weight = 1f;

        reportView = new TextView(this);
        reportView.setText(R.string.report_placeholder);
        reportView.setTextSize(TypedValue.COMPLEX_UNIT_SP, 14);
        reportView.setTypeface(Typeface.MONOSPACE);
        reportView.setTextIsSelectable(true);

        scrollView.addView(reportView, new ScrollView.LayoutParams(
            ViewGroup.LayoutParams.MATCH_PARENT,
            ViewGroup.LayoutParams.WRAP_CONTENT));

        root.addView(scrollView, scrollParams);
        return root;
    }

    private void runProbe() {
        statusView.setText(R.string.status_running);
        reportView.setText(R.string.report_running);
        rerunButton.setEnabled(false);

        executor.execute(() -> {
            final File internalDir = getFilesDir();
            final File externalDir = getExternalFilesDir(null);
            final String report = runProbeNative(
                internalDir != null ? internalDir.getAbsolutePath() : "",
                externalDir != null ? externalDir.getAbsolutePath() : "");

            mainHandler.post(() -> {
                statusView.setText(R.string.status_finished);
                reportView.setText(report);
                rerunButton.setEnabled(true);
            });
        });
    }

    private int dp(int value) {
        return Math.round(
            TypedValue.applyDimension(
                TypedValue.COMPLEX_UNIT_DIP,
                value,
                getResources().getDisplayMetrics()));
    }
}

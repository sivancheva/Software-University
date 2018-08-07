<?php

/* @WebProfiler/Collector/ajax.html.twig */
class __TwigTemplate_f19207bdaa345ac6ca9e4eed27ef2e43bf0cde21d4a71567dbeed8fa538747ef extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/ajax.html.twig", 1);
        $this->blocks = array(
            'toolbar' => array($this, 'block_toolbar'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_acfd9cbcef2e12b2841a08b4cbad8581e796b7d4aac5f682f83d444a6c2246d2 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_acfd9cbcef2e12b2841a08b4cbad8581e796b7d4aac5f682f83d444a6c2246d2->enter($__internal_acfd9cbcef2e12b2841a08b4cbad8581e796b7d4aac5f682f83d444a6c2246d2_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/ajax.html.twig"));

        $__internal_6cd59c858b4daca407f208bd512e8e8e1e0fd868e197969a3339a99eefd2f625 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_6cd59c858b4daca407f208bd512e8e8e1e0fd868e197969a3339a99eefd2f625->enter($__internal_6cd59c858b4daca407f208bd512e8e8e1e0fd868e197969a3339a99eefd2f625_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/ajax.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_acfd9cbcef2e12b2841a08b4cbad8581e796b7d4aac5f682f83d444a6c2246d2->leave($__internal_acfd9cbcef2e12b2841a08b4cbad8581e796b7d4aac5f682f83d444a6c2246d2_prof);

        
        $__internal_6cd59c858b4daca407f208bd512e8e8e1e0fd868e197969a3339a99eefd2f625->leave($__internal_6cd59c858b4daca407f208bd512e8e8e1e0fd868e197969a3339a99eefd2f625_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_bd4ce9764328a276213402e428af7789121d111318173e45fb4499e541321c60 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_bd4ce9764328a276213402e428af7789121d111318173e45fb4499e541321c60->enter($__internal_bd4ce9764328a276213402e428af7789121d111318173e45fb4499e541321c60_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        $__internal_610f0b3b98707f77ab1f25f797c21720619160b7dc68d3c29dac399619cc933a = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_610f0b3b98707f77ab1f25f797c21720619160b7dc68d3c29dac399619cc933a->enter($__internal_610f0b3b98707f77ab1f25f797c21720619160b7dc68d3c29dac399619cc933a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        // line 4
        echo "    ";
        ob_start();
        // line 5
        echo "        ";
        echo twig_include($this->env, $context, "@WebProfiler/Icon/ajax.svg");
        echo "
        <span class=\"sf-toolbar-value sf-toolbar-ajax-request-counter\">0</span>
    ";
        $context["icon"] = ('' === $tmp = ob_get_clean()) ? '' : new Twig_Markup($tmp, $this->env->getCharset());
        // line 8
        echo "
    ";
        // line 9
        $context["text"] = ('' === $tmp = "        <div class=\"sf-toolbar-info-piece\">
            <b class=\"sf-toolbar-ajax-info\"></b>
        </div>
        <div class=\"sf-toolbar-info-piece\">
            <table class=\"sf-toolbar-ajax-requests\">
                <thead>
                    <tr>
                        <th>Method</th>
                        <th>Type</th>
                        <th>Status</th>
                        <th>URL</th>
                        <th>Time</th>
                        <th>Profile</th>
                    </tr>
                </thead>
                <tbody class=\"sf-toolbar-ajax-request-list\"></tbody>
            </table>
        </div>
    ") ? '' : new Twig_Markup($tmp, $this->env->getCharset());
        // line 29
        echo "
    ";
        // line 30
        echo twig_include($this->env, $context, "@WebProfiler/Profiler/toolbar_item.html.twig", array("link" => false));
        echo "
";
        
        $__internal_610f0b3b98707f77ab1f25f797c21720619160b7dc68d3c29dac399619cc933a->leave($__internal_610f0b3b98707f77ab1f25f797c21720619160b7dc68d3c29dac399619cc933a_prof);

        
        $__internal_bd4ce9764328a276213402e428af7789121d111318173e45fb4499e541321c60->leave($__internal_bd4ce9764328a276213402e428af7789121d111318173e45fb4499e541321c60_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/ajax.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  85 => 30,  82 => 29,  62 => 9,  59 => 8,  52 => 5,  49 => 4,  40 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block toolbar %}
    {% set icon %}
        {{ include('@WebProfiler/Icon/ajax.svg') }}
        <span class=\"sf-toolbar-value sf-toolbar-ajax-request-counter\">0</span>
    {% endset %}

    {% set text %}
        <div class=\"sf-toolbar-info-piece\">
            <b class=\"sf-toolbar-ajax-info\"></b>
        </div>
        <div class=\"sf-toolbar-info-piece\">
            <table class=\"sf-toolbar-ajax-requests\">
                <thead>
                    <tr>
                        <th>Method</th>
                        <th>Type</th>
                        <th>Status</th>
                        <th>URL</th>
                        <th>Time</th>
                        <th>Profile</th>
                    </tr>
                </thead>
                <tbody class=\"sf-toolbar-ajax-request-list\"></tbody>
            </table>
        </div>
    {% endset %}

    {{ include('@WebProfiler/Profiler/toolbar_item.html.twig', { link: false }) }}
{% endblock %}
", "@WebProfiler/Collector/ajax.html.twig", "C:\\Users\\Ship\\Desktop\\STExam\\PHP-Skeleton\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\WebProfilerBundle\\Resources\\views\\Collector\\ajax.html.twig");
    }
}

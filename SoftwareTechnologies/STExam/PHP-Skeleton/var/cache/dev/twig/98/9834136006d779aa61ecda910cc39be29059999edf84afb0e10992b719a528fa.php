<?php

/* @WebProfiler/Collector/router.html.twig */
class __TwigTemplate_09886c37796d81d574b2448cf2a22ea32da8dad546b69f22c376ce19a869ce97 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/router.html.twig", 1);
        $this->blocks = array(
            'toolbar' => array($this, 'block_toolbar'),
            'menu' => array($this, 'block_menu'),
            'panel' => array($this, 'block_panel'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_4ecba87ec9cce58d3fd62c094dd5c110af37913d5a8e7fa66416797a2a2f44c3 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_4ecba87ec9cce58d3fd62c094dd5c110af37913d5a8e7fa66416797a2a2f44c3->enter($__internal_4ecba87ec9cce58d3fd62c094dd5c110af37913d5a8e7fa66416797a2a2f44c3_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $__internal_8e2027c4d727bdc774c08d163a9578bc0fdb3cc3e7cb09705b7886b3ad87969b = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_8e2027c4d727bdc774c08d163a9578bc0fdb3cc3e7cb09705b7886b3ad87969b->enter($__internal_8e2027c4d727bdc774c08d163a9578bc0fdb3cc3e7cb09705b7886b3ad87969b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_4ecba87ec9cce58d3fd62c094dd5c110af37913d5a8e7fa66416797a2a2f44c3->leave($__internal_4ecba87ec9cce58d3fd62c094dd5c110af37913d5a8e7fa66416797a2a2f44c3_prof);

        
        $__internal_8e2027c4d727bdc774c08d163a9578bc0fdb3cc3e7cb09705b7886b3ad87969b->leave($__internal_8e2027c4d727bdc774c08d163a9578bc0fdb3cc3e7cb09705b7886b3ad87969b_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_e907941785ef7b2f76d16d2a12c663fdc33cb13f4a574eff6c63819504e51ec1 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_e907941785ef7b2f76d16d2a12c663fdc33cb13f4a574eff6c63819504e51ec1->enter($__internal_e907941785ef7b2f76d16d2a12c663fdc33cb13f4a574eff6c63819504e51ec1_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        $__internal_4262fcf69be25bf0b3def8530e6ec69a32ac98b38828c2ada8826be02584bca7 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_4262fcf69be25bf0b3def8530e6ec69a32ac98b38828c2ada8826be02584bca7->enter($__internal_4262fcf69be25bf0b3def8530e6ec69a32ac98b38828c2ada8826be02584bca7_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        
        $__internal_4262fcf69be25bf0b3def8530e6ec69a32ac98b38828c2ada8826be02584bca7->leave($__internal_4262fcf69be25bf0b3def8530e6ec69a32ac98b38828c2ada8826be02584bca7_prof);

        
        $__internal_e907941785ef7b2f76d16d2a12c663fdc33cb13f4a574eff6c63819504e51ec1->leave($__internal_e907941785ef7b2f76d16d2a12c663fdc33cb13f4a574eff6c63819504e51ec1_prof);

    }

    // line 5
    public function block_menu($context, array $blocks = array())
    {
        $__internal_e5f70d32b4ee124b84311a6d38e3f44a29e0e5e224f586cb4f6f2a630b3b76d8 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_e5f70d32b4ee124b84311a6d38e3f44a29e0e5e224f586cb4f6f2a630b3b76d8->enter($__internal_e5f70d32b4ee124b84311a6d38e3f44a29e0e5e224f586cb4f6f2a630b3b76d8_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        $__internal_8e7b7c4833ec504fad0af95ef0b47e4f99d2da97ef9f6108711258747e6ca4f5 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_8e7b7c4833ec504fad0af95ef0b47e4f99d2da97ef9f6108711258747e6ca4f5->enter($__internal_8e7b7c4833ec504fad0af95ef0b47e4f99d2da97ef9f6108711258747e6ca4f5_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 6
        echo "<span class=\"label\">
    <span class=\"icon\">";
        // line 7
        echo twig_include($this->env, $context, "@WebProfiler/Icon/router.svg");
        echo "</span>
    <strong>Routing</strong>
</span>
";
        
        $__internal_8e7b7c4833ec504fad0af95ef0b47e4f99d2da97ef9f6108711258747e6ca4f5->leave($__internal_8e7b7c4833ec504fad0af95ef0b47e4f99d2da97ef9f6108711258747e6ca4f5_prof);

        
        $__internal_e5f70d32b4ee124b84311a6d38e3f44a29e0e5e224f586cb4f6f2a630b3b76d8->leave($__internal_e5f70d32b4ee124b84311a6d38e3f44a29e0e5e224f586cb4f6f2a630b3b76d8_prof);

    }

    // line 12
    public function block_panel($context, array $blocks = array())
    {
        $__internal_15017c2d8044e1880bc64e1ad757cccc97300a026f73072472f9bbe8228a00e8 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_15017c2d8044e1880bc64e1ad757cccc97300a026f73072472f9bbe8228a00e8->enter($__internal_15017c2d8044e1880bc64e1ad757cccc97300a026f73072472f9bbe8228a00e8_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        $__internal_25777a405fc631a767f3641d6119bd7c14b895709acc32a4bf96809fa4dca273 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_25777a405fc631a767f3641d6119bd7c14b895709acc32a4bf96809fa4dca273->enter($__internal_25777a405fc631a767f3641d6119bd7c14b895709acc32a4bf96809fa4dca273_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 13
        echo "    ";
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_router", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
        echo "
";
        
        $__internal_25777a405fc631a767f3641d6119bd7c14b895709acc32a4bf96809fa4dca273->leave($__internal_25777a405fc631a767f3641d6119bd7c14b895709acc32a4bf96809fa4dca273_prof);

        
        $__internal_15017c2d8044e1880bc64e1ad757cccc97300a026f73072472f9bbe8228a00e8->leave($__internal_15017c2d8044e1880bc64e1ad757cccc97300a026f73072472f9bbe8228a00e8_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/router.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  94 => 13,  85 => 12,  71 => 7,  68 => 6,  59 => 5,  42 => 3,  11 => 1,);
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

{% block toolbar %}{% endblock %}

{% block menu %}
<span class=\"label\">
    <span class=\"icon\">{{ include('@WebProfiler/Icon/router.svg') }}</span>
    <strong>Routing</strong>
</span>
{% endblock %}

{% block panel %}
    {{ render(path('_profiler_router', { token: token })) }}
{% endblock %}
", "@WebProfiler/Collector/router.html.twig", "C:\\Users\\Ship\\Desktop\\STExam\\PHP-Skeleton\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\WebProfilerBundle\\Resources\\views\\Collector\\router.html.twig");
    }
}
